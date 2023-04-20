using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;

namespace BUS
{
    public class Bill_BUS
    {
        public static Bill_DTO SearchBillsForFilter_BUS(string HistoryID)
        {
            return DAO.Bill_DAO.SearchBillsForFilter(HistoryID);
        }

        public static DataTable SearchBills_BUS(string HistoryID)
        {
            return DAO.Bill_DAO.SearchBills(HistoryID);
        }
    }
}
