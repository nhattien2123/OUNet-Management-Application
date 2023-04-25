using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Services_BUS
    {
        public static List<Services_DTO> ListServices_BUS(string type)
        {
            return DAO.Services_DAO.ListServices(type);
        }

        public static string UpdateService(string serviceID, int quantity, int price)
        {
            return DAO.Services_DAO.UpdateService(serviceID, quantity, price);
        }

        public static string PayBillService(List<DTO.OrderService_DTO> orderList, string userID, string adminID, string description)
        {
            return DAO.Services_DAO.PayBillService(orderList, userID, adminID, description);
        }

        public static string PayBillMService(List<DTO.OrderService_DTO> orderList, string userID, string adminID)
        {
            return DAO.Services_DAO.PayBillMService(orderList, userID, adminID);
        }

        public static string BillDFFromUser(List<DTO.OrderService_DTO> orderList, string userID, string userPhone, string description, string sName)
        {
            return DAO.Services_DAO.BillDFFromUser(orderList, userID, userPhone, description, sName);

        }

        public static string BillMFromUser(DTO.Services_DTO moneyItem, string userID, string userPhone, string sName)
        {
            return DAO.Services_DAO.BillMFromUser(moneyItem, userID, userPhone, sName);
        }

        public static List<Services_DTO> GetListMoney()
        {
            return DAO.Services_DAO.GetListMoney();
        }
    }
}
