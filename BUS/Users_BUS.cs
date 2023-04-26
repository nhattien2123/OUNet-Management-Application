using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static string ChangeStatusUser_BUS(Users_DTO user)
        {
            return DAO.Users_DAO.ChangeStatusUser(user);
        }

        public static string ChangePassword_BUS(Users_DTO user)
        {
            return DAO.Users_DAO.ChangePassword(user);
        }
        
        public static List<Users_DTO> SearchUser_BUS(string search, string colName, string status)
        {
            return DAO.Users_DAO.SearchUser(search, colName, status);
        }

        public static Users_DTO CheckAccount_BUS(string tel, string password)
        {
            return DAO.Users_DAO.CheckAccount(tel, password);
        }

        public static Users_DTO CheckAccount_BUS(string tel)
        {
            return DAO.Users_DAO.CheckAccount(tel);
        }

        public static bool CheckPassword_BUS(string tel, string password)
        {
            return DAO.Users_DAO.CheckPassword(tel, password);
        }

        public static DataTable DataTableUsers_BUS()
        {
            return DAO.Users_DAO.DataTableUsers();
        }

        public static string SubMoneyFromUser(float money, string userID, Boolean subMoney)
        {
            return DAO.Users_DAO.SubMoneyFromUser(money, userID,subMoney);
        }

        public static string AddMoneyFromUser(int money, string userID)
        {
            return DAO.Users_DAO.AddMoneyFromUser(money, userID);
        }
    }
}
