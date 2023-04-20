using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class History_DAO
    {
        public static List<History_DTO> ListHistory()
        {
            List<History_DTO> listHistory = new List<History_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL("SELECT * FROM dbo.History ORDER BY Time DESC");
            History_DTO history;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                history = new History_DTO();
                history.HistoryID = dt.Rows[i]["HistoryID"].ToString();
                history.UserID = dt.Rows[i]["UserID"].ToString();
                history.AdminID = dt.Rows[i]["AdminID"].ToString();
                history.Description = dt.Rows[i]["Description"].ToString();
                history.Time = DateTime.Parse(dt.Rows[i]["Time"].ToString());
                listHistory.Add(history);
            }
            return listHistory;
        }
    }
}
