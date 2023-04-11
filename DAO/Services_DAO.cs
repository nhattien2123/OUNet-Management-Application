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
        public static List<Services_DTO> ListServices()
        {
            List<Services_DTO> ListServices = new List<Services_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL("SELECT * FROM Services s, DetailService d Where d.ServiceID = s.ServiceID");
            Services_DTO services;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                services = new Services_DTO();
                services.ServiceID = dt.Rows[i]["ServiceID"].ToString();
                services.ServiceImage = dt.Rows[i]["ImageName"].ToString();
                services.ServiceName = dt.Rows[i]["ServiceName"].ToString();
                services.Price = dt.Rows[i]["Price"].ToString();
                services.ServiceQuantity = dt.Rows[i]["Quantity"].ToString();
                ListServices.Add(services);
            }
            return ListServices;
        }

        public static string UpdateService(string serviceID, int quantity, int price) {
            string sqlcmd = $"BEGIN TRANSACTION UPDATE Services SET Price = {price} WHERE ServiceID = N'{serviceID}' UPDATE DetailService SET Quantity = {quantity} WHERE ServiceID = N'{serviceID}' COMMIT";
            
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }
    }
}
