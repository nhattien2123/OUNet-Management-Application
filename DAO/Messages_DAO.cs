using DTO;
using Microsoft.SqlServer.Server;
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
                message.UserSend = dt.Rows[i]["UserSend"].ToString();
                listMessages.Add(message);
            }
            return listMessages;
        }

        // Hàm thêm tin nhắn
        public static string AddMessage(Messages_DTO message)
        {
            string sqlcmd = string.Format("INSERT INTO dbo.Messages(MessageID, Content, Time, UserID, AdminID, UserSend) " +
                "VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')", message.MessageID, message.Content, message.Time, message.UserID, message.AdminID, message.UserSend);
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }

        // Hàm trả về tin nhắn giữa hai user bất kì
        public static List<Messages_DTO> TwoUsersListMessages(Users_DTO user1, Users_DTO user2)
        {
            List<Messages_DTO> listMessages = new List<Messages_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL(String.Format("SELECT * FROM dbo.Messages WHERE AdminID = N'{0}' AND UserID = N'{1}' ORDER BY Time", user1.UserID, user2.UserID));
            Messages_DTO message;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                message = new Messages_DTO();
                message.MessageID = dt.Rows[i]["MessageID"].ToString();
                message.Content = dt.Rows[i]["Content"].ToString();
                message.Time = DateTime.Parse(dt.Rows[i]["Time"].ToString());
                message.UserID = dt.Rows[i]["UserID"].ToString();
                message.AdminID = dt.Rows[i]["AdminID"].ToString();
                message.UserSend = dt.Rows[i]["UserSend"].ToString();
                listMessages.Add(message);
            }
            return listMessages;
        }
    }
}
