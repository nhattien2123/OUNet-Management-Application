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
        public static Bill_DTO SearchBillsForFilter(string HistoryID)
        {

            DataTable dt = ProcessingDAO.RunQuerySQL(string.Format("SELECT TOP(1) * FROM dbo.Bill WHERE Bill.HistoryID = N'{0}'", HistoryID));
            Bill_DTO bill = new Bill_DTO();
            bill.BillID = dt.Rows[0]["BillID"].ToString();
            bill.HistoryID = dt.Rows[0]["HistoryID"].ToString();
            bill.ServiceID = dt.Rows[0]["ServiceID"].ToString();
            bill.Quantity = int.Parse(dt.Rows[0]["Quantity"].ToString());
            bill.Total = int.Parse(dt.Rows[0]["Total"].ToString());
            return bill;
        }

        public static DataTable SearchBills(string HistoryID)
        {
            string sqlcmd = string.Format("SELECT Bill.HistoryID, Bill.BillID, Services.ServiceName, Services.Price, Bill.Quantity, Bill.Total FROM Bill INNER JOIN Services ON Bill.ServiceID = Services.ServiceID WHERE Bill.HistoryID = N'{0}'", HistoryID);
            DataTable dt = ProcessingDAO.RunQuerySQL(sqlcmd);
            return dt;
        }
    }
}
