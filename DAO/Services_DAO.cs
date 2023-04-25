using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Services_DAO
    {
        // Hàm lấy danh sách dịch vụ
        public static List<Services_DTO> ListServices(string type)
        {
            List<Services_DTO> ListServices = new List<Services_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL($"SELECT * FROM Services s, DetailService d Where d.ServiceID = s.ServiceID and s.ServiceID LIKE N'{type}%'");
            Services_DTO services;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                services = new Services_DTO();
                services.ServiceID = dt.Rows[i]["ServiceID"].ToString();
                services.ServiceImage = dt.Rows[i]["ImageName"].ToString();
                services.ServiceName = dt.Rows[i]["ServiceName"].ToString();
                services.Price = float.Parse(dt.Rows[i]["Price"].ToString());
                services.ServiceQuantity = dt.Rows[i]["Quantity"].ToString();
                ListServices.Add(services);
            }
            return ListServices;
        }

        public static string UpdateService(string serviceID, int quantity, int price)
        {
            string sqlcmd = $"BEGIN TRANSACTION UPDATE Services SET Price = {price} WHERE ServiceID = N'{serviceID}' UPDATE DetailService SET Quantity = {quantity} WHERE ServiceID = N'{serviceID}' COMMIT";
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }

        public static string PayBillService(List<DTO.OrderService_DTO> orderList, string userID, string adminID, string description)
        {
            string insert = "";
            string update = "";
            foreach (DTO.OrderService_DTO item in orderList)
            {
                insert += $"(N'{item.ServiceID}', {item.ServiceQuantity}, {item.ServiceTotal}, @@IDENTITY), ";
                update += $"UPDATE DetailService set Quantity = Quantity - {item.ServiceQuantity} where ServiceId = N'{item.ServiceID}';";
            }
            insert = insert.Substring(0, insert.Length - 2);
            string sqlcmd = $"DECLARE @currDate DATETIME; SET @currDate = GETDATE(); INSERT INTO History(UserID, AdminID, Description, Time, Status) VALUES(N'{userID}', N'{adminID}', N'{description}', @currDate, 1); INSERT INTO Bill(ServiceID, Quantity, Total, HistoryID) VALUES{insert}; BEGIN TRANSACTION {update} COMMIT";
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }

        public static string PayBillMService(List<DTO.OrderService_DTO> orderList, string userID, string adminID)
        {
            
            string sqlcmd = $"DECLARE @currDate DATETIME; SET @currDate = GETDATE(); DECLARE @Price float; DECLARE @Bonus float; SELECT @Price = s.Price, @Bonus = ISNULL(v.Bonus, 0) FROM Services AS s LEFT JOIN Voucher AS v ON s.ServiceID = v.ServiceID where s.ServiceID = N'{orderList[0].ServiceID}' INSERT INTO History(UserID, AdminID, Time, Status) VALUES(N'{userID}', N'{adminID}', @currDate, 1); INSERT INTO Bill(ServiceID, Quantity, Total, HistoryID) VALUES(N'{orderList[0].ServiceID}', 1, {orderList[0].ServicePrice}, @@IDENTITY); BEGIN TRANSACTION UPDATE Users set M_Account = M_Account + @Price, S_Account = S_Account + @Bonus where Users.UserID = N'{userID}' COMMIT";
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }

        public static string BillDFFromUser(List<DTO.OrderService_DTO> orderList, string userID, string userPhone, string description, string sName)
        {
            string txt = $"Order*U>{userID}&{userPhone}*D>{description}*S>{sName}*";
            foreach (DTO.OrderService_DTO item in orderList)
            {
                txt += $"DF-{item.ServiceID}-{item.ServiceName}-{item.ServiceQuantity}-{item.ServicePrice};";
            }
           
            return txt;
        }

        public static string BillMFromUser(Services_DTO moneyItem, string userID, string userPhone, string sName)
        {
            string txt = $"Order*U>{userID}&{userPhone}*D>string*S>{sName}*M-{moneyItem.ServiceID.Trim()}-{moneyItem.ServiceName}-{moneyItem.Price};";
            return txt;
        }

        public static List<Services_DTO> GetListMoney()
        {
            List<Services_DTO> ListMoney = new List<Services_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL($"SELECT s.ServiceID, ServiceName, s.Price, v.Bonus FROM Services AS s LEFT JOIN Voucher AS v ON s.ServiceID = v.ServiceID where s.ServiceID LIKE 'M%'");
            Services_DTO services;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                services = new Services_DTO();
                services.ServiceID = dt.Rows[i]["ServiceID"].ToString();
                services.ServiceName = dt.Rows[i]["ServiceName"].ToString();
                services.Price = int.Parse(dt.Rows[i]["Price"].ToString());
                services.ServiceQuantity = String.IsNullOrEmpty(dt.Rows[i]["Bonus"].ToString()) ? "- - -" : dt.Rows[i]["Bonus"].ToString();
                ListMoney.Add(services);
            }
            return ListMoney;
        }
    }
}
