using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Bill_DAO
    {
        public static DataTable SearchBills(string HistoryID)
        {
            string sqlcmd = string.Format("SELECT Bill.HistoryID, Bill.BillID, Services.ServiceName, Services.Price, Bill.Quantity, Bill.Total FROM Bill INNER JOIN Services ON Bill.ServiceID = Services.ServiceID WHERE Bill.HistoryID = N'{0}'", HistoryID);
            DataTable dt = ProcessingDAO.RunQuerySQL(sqlcmd);
            return dt;
        }
    }
}
