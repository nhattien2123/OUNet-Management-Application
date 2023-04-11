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
        public static List<Services_DTO> ListServices_BUS()
        {
            return DAO.Services_DAO.ListServices();
        }

        public static string UpdateService(string serviceID, int quantity, int price)
        {
            return DAO.Services_DAO.UpdateService(serviceID, quantity, price);
        }
    }
}
