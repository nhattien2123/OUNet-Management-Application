using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Messages_DAO
    {
        public static List<Messages_DTO> ListMessages()
        {
            List<Messages_DTO> listMessages = new List<Messages_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL("SELECT * FROM dbo.Messages");
            Messages_DTO message;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                message = new Messages_DTO();
                message.MessageID = dt.Rows[i]["MessageID"].ToString();
                message.Content = dt.Rows[i]["Content"].ToString();
                message.Time = DateTime.Parse(dt.Rows[i]["Time"].ToString());
                message.UserID = dt.Rows[i]["UserID"].ToString();
                message.AdminID = dt.Rows[i]["AdminID"].ToString();
                listMessages.Add(message);
            }
            return listMessages;
        }
    }
}
