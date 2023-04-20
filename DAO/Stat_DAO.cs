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
    public class Stat_DAO
    {
        // Hàm lấy danh sách dịch vụ
        public static string TotalDFService(string timeStart, string timeEnd)
        {
            string sqlcmd = $"SELECT SUM(b.total) as N'ServiceDF' FROM bill b JOIN history h ON b.historyID = h.historyID JOIN Services s ON b.serviceID = s.serviceID WHERE h.Time < CAST(N'{timeEnd}' as datetime) and h.Time > CAST(N'{timeStart}' as datetime) and (s.serviceID LIKE 'D%' or s.serviceID LIKE 'F%');";
            DataTable dt = ProcessingDAO.RunQuerySQL(sqlcmd);
            string val = dt.Rows[0]["ServiceDF"].ToString();
            if (String.IsNullOrEmpty(val)) val = "0";
            return val;
        }

        public static string TotalMService(string timeStart, string timeEnd)
        {
            string sqlcmd = $"SELECT SUM(b.total) as N'ServiceDF' FROM bill b JOIN history h ON b.historyID = h.historyID JOIN Services s ON b.serviceID = s.serviceID WHERE h.Time < CAST(N'{timeEnd}' as datetime) and h.Time > CAST(N'{timeStart}' as datetime) and (s.serviceID LIKE 'M%');";
            DataTable dt = ProcessingDAO.RunQuerySQL(sqlcmd);
            string val = dt.Rows[0]["ServiceDF"].ToString();
            if (String.IsNullOrEmpty(val)) val = "0";
            return val;
        }
    }
}
