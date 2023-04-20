using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Stat_BUS
    {
        public static string TotalDFService(string timeStart, string timeEnd)
        {
            return DAO.Stat_DAO.TotalDFService(timeStart, timeEnd);
        }

        public static string TotalMService(string timeStart, string timeEnd)
        {
            return DAO.Stat_DAO.TotalMService(timeStart, timeEnd);
        }
    }
}
