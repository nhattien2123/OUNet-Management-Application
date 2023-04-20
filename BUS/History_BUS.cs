using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class History_BUS
    {
        public static List<History_DTO> ListHistory_BUS()
        {
            return DAO.History_DAO.ListHistory();
        }
    }
}
