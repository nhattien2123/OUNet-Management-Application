using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DetailService_BUS
    {
        public static List<DetailService_DTO> ListDetailService_BUS()
        {
            return DAO.DetailService_DAO.ListDetailService();
        }
    }
}
