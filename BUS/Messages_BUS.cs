using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Messages_BUS
    {
        public static List<Messages_DTO> ListMessages_BUS()
        {
            return DAO.Messages_DAO.ListMessages();
        }

        public static string AddMessage_BUS(Messages_DTO message)
        {
            return DAO.Messages_DAO.AddMessage(message);
        }

        public static List<Messages_DTO> TwoUsersListMessages_BUS(Users_DTO user1, Users_DTO user2)
        {
            return DAO.Messages_DAO.TwoUsersListMessages(user1, user2);
        }
    }
}
