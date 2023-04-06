using DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Users_DAO
    {
        // Hàm lấy dữ liệu người dùng
        public static List<Users_DTO> ListUsers()
        {
            List<Users_DTO> listUsers = new List<Users_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL("SELECT UserID, Username, Tel, Address, Role, M_Account, S_Account, LastAccess, Status, Nation, Sex, HomeTown, BirthDay FROM dbo.Users");
            Users_DTO user;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                user = new Users_DTO();
                user.UserID = dt.Rows[i]["UserID"].ToString();
                user.Username = dt.Rows[i]["Username"].ToString();
                user.Tel = dt.Rows[i]["Tel"].ToString();
                user.Address = dt.Rows[i]["Address"].ToString();
                user.Role = dt.Rows[i]["Role"].ToString();
                user.M_Account = float.Parse(dt.Rows[i]["M_Account"].ToString());
                user.S_Account = float.Parse(dt.Rows[i]["S_Account"].ToString());
                user.LastAccess = DateTime.Parse(dt.Rows[i]["LastAccess"].ToString());
                user.Status = bool.Parse(dt.Rows[i]["Status"].ToString());
                user.Nation = dt.Rows[i]["Nation"].ToString();
                user.Sex = dt.Rows[i]["Sex"].ToString();
                user.HomeTown = dt.Rows[i]["HomeTown"].ToString();
                user.BirthDay = DateTime.Parse(dt.Rows[i]["BirthDay"].ToString());
                listUsers.Add(user);
            }
            return listUsers;
        }

        // Hàm thêm người dùng
        public static string AddUser(Users_DTO user)
        {
            string sqlcmd = string.Format("INSERT INTO dbo.Users(UserID, Username, Tel, Password, Address, Role, M_Account, S_Account, LastAccess, Status, Nation, Sex, HomeTown, BirthDay) " +
                "VALUES(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}')", user.UserID, user.Username, user.Tel, user.Password, user.Address, user.Role, user.M_Account, user.S_Account, user.LastAccess, user.Status, user.Nation, user.Sex, user.HomeTown, user.BirthDay);
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }

        // Hàm chỉnh sửa thông tin người dùng
        public static string EditUser(Users_DTO user, string UserID)
        {
            string sqledit = "";
            sqledit += "Username = N'" + user.Username + "',";
            sqledit += "Tel = N'" + user.Tel + "',";
            sqledit += "Password = N'" + user.Password + "',";
            sqledit += "Address = N'" + user.Address + "',";
            sqledit += "Nation = N'" + user.Nation + "',";
            sqledit += "Sex = N'" + user.Sex + "',";
            sqledit += "HomeTown = N'" + user.HomeTown + "',";
            sqledit += "BirthDay = N'" + user.BirthDay + "'";

            string sqlcmd = string.Format("UPDATE dbo.Users SET {0} WHERE UserID = '{1}';",
                sqledit, UserID);
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }

        // Hàm xoá thông tin người dùng
        public static string DeleteUser(Users_DTO user)
        {
            string sqlcmd = string.Format("DELETE FROM dbo.Users WHERE UserID = '{0}';", user.UserID);
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }

        // Hàm đổi mật khẩu người dùng
        public static string ChangePassword(Users_DTO user) 
        {
            string sqlcmd = string.Format("UPDATE dbo.Users SET Password = N'{0}' WHERE UserID = '{1}';", user.Password, user.UserID);
            return ProcessingDAO.RunNonQuerySQL(sqlcmd);
        }

        // Hàm tìm kiếm người dùng
        public static List<Users_DTO> SearchUser(string search, string colName, string status)
        {

            string sqlcmd = string.Format("SELECT UserID, Username, Tel, Address, Role, M_Account, S_Account, LastAccess, Status, Nation, Sex, HomeTown, BirthDay FROM dbo.Users WHERE {0} LIKE N'%{1}%' AND Status = N'{2}'", colName, search, status);
            List<Users_DTO> listUsers = new List<Users_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL(sqlcmd);
            Users_DTO user;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                user = new Users_DTO();
                user.UserID = dt.Rows[i]["UserID"].ToString();
                user.Username = dt.Rows[i]["Username"].ToString();
                user.Tel = dt.Rows[i]["Tel"].ToString();
                user.Address = dt.Rows[i]["Address"].ToString();
                user.Role = dt.Rows[i]["Role"].ToString();
                user.M_Account = float.Parse(dt.Rows[i]["M_Account"].ToString());
                user.S_Account = float.Parse(dt.Rows[i]["S_Account"].ToString());
                user.LastAccess = DateTime.Parse(dt.Rows[i]["LastAccess"].ToString());
                user.Status = bool.Parse(dt.Rows[i]["Status"].ToString());
                user.Nation = dt.Rows[i]["Nation"].ToString();
                user.Sex = dt.Rows[i]["Sex"].ToString();
                user.HomeTown = dt.Rows[i]["HomeTown"].ToString();
                user.BirthDay = DateTime.Parse(dt.Rows[i]["BirthDay"].ToString());
                listUsers.Add(user);
            }
            return listUsers;
        }

        // Hàm kiểm tra và trả về khi người dùng đăng nhập
        public static Users_DTO CheckAccount(string tel, string password)
        {
            DataTable dt = ProcessingDAO.RunQuerySQL(String.Format("SELECT UserID, Username, Tel, Address, Role, M_Account, S_Account, LastAccess, Status, Nation, Sex, HomeTown, BirthDay FROM dbo.Users WHERE Tel = N'{0}' AND Password = N'{1}'", tel, password));
            Users_DTO user = new Users_DTO();
            if (dt.Rows.Count > 0)
            {
                user.UserID = dt.Rows[0]["UserID"].ToString();
                user.Username = dt.Rows[0]["Username"].ToString();
                user.Tel = dt.Rows[0]["Tel"].ToString();
                user.Address = dt.Rows[0]["Address"].ToString();
                user.Role = dt.Rows[0]["Role"].ToString();
                user.M_Account = float.Parse(dt.Rows[0]["M_Account"].ToString());
                user.S_Account = float.Parse(dt.Rows[0]["S_Account"].ToString());
                user.LastAccess = DateTime.Parse(dt.Rows[0]["LastAccess"].ToString());
                user.Status = bool.Parse(dt.Rows[0]["Status"].ToString());
                user.Nation = dt.Rows[0]["Nation"].ToString();
                user.Sex = dt.Rows[0]["Sex"].ToString();
                user.HomeTown = dt.Rows[0]["HomeTown"].ToString();
                user.BirthDay = DateTime.Parse(dt.Rows[0]["BirthDay"].ToString());
            }
            return user;
        }

        // Hàm kiểm tra mật khẩu
        public static bool CheckPassword(string tel, string password)
        {
            DataTable dt = ProcessingDAO.RunQuerySQL(String.Format("SELECT UserID FROM dbo.Users WHERE Tel = N'{0}' AND Password = N'{1}'", tel, password));
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // Hàm trả về danh sách người dùng ( DataTable )
        public static DataTable DataTableUsers()
        {
            return ProcessingDAO.RunQuerySQL("SELECT UserID, Username, Tel, Address, Role, M_Account, S_Account, LastAccess, Status, Nation, Sex, HomeTown, BirthDay FROM dbo.Users");
        }

        public static Users_DTO CheckAccount(string tel)
        {
            DataTable dt = ProcessingDAO.RunQuerySQL(String.Format("SELECT UserID, Username, Tel, Address, Role, M_Account, S_Account, LastAccess, Status, Nation, Sex, HomeTown, BirthDay FROM dbo.Users WHERE Tel = N'{0}'", tel));
            Users_DTO user = new Users_DTO();
            if (dt.Rows.Count > 0)
            {
                user.UserID = dt.Rows[0]["UserID"].ToString();
                user.Username = dt.Rows[0]["Username"].ToString();
                user.Tel = dt.Rows[0]["Tel"].ToString();
                user.Address = dt.Rows[0]["Address"].ToString();
                user.Role = dt.Rows[0]["Role"].ToString();
                user.M_Account = float.Parse(dt.Rows[0]["M_Account"].ToString());
                user.S_Account = float.Parse(dt.Rows[0]["S_Account"].ToString());
                user.LastAccess = DateTime.Parse(dt.Rows[0]["LastAccess"].ToString());
                user.Status = bool.Parse(dt.Rows[0]["Status"].ToString());
                user.Nation = dt.Rows[0]["Nation"].ToString();
                user.Sex = dt.Rows[0]["Sex"].ToString();
                user.HomeTown = dt.Rows[0]["HomeTown"].ToString();
                user.BirthDay = DateTime.Parse(dt.Rows[0]["BirthDay"].ToString());
            }
            return user;
        }
    }
}
