using DTO;
using System;
using System.Collections.Generic;
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
    }
}
