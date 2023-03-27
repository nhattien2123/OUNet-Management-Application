using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Users_BUS
    {
        public static List<Users_DTO> ListUsers_BUS()
        {
            return DAO.Users_DAO.ListUsers();
        }

        public static string AddUser_BUS(Users_DTO user)
        {
            return DAO.Users_DAO.AddUser(user);
        }

        public static string EditUser_BUS(Users_DTO user, string UserID)
        {
            return DAO.Users_DAO.EditUser(user, UserID);
        }

        public static string DeleteUser_BUS(Users_DTO user)
        {
            return DAO.Users_DAO.DeleteUser(user);
        }

        public static string ChangePassword_BUS(Users_DTO user)
        {
            return DAO.Users_DAO.ChangePassword(user);
        }
    }
}
