using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class ProcessingDAO
    {
        // Chuỗi kết nối
        public static string cnnStr = @"Data Source=ounet.database.windows.net; Initial Catalog=OUNET; User ID=ousqladmin;Password=Ounetadmin123";
        // Hàm chạy lệnh SQL lấy dữ liệu - loại Data Query
        public static DataTable RunQuerySQL(string sqlCmd)
        {
            SqlConnection cnn = new SqlConnection(cnnStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = sqlCmd;
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable kq = new DataTable();
            adt.Fill(kq);
            return kq;
        }

        // Hàm chạy lệnh thêm, sửa, xoá - loại NonQuery
        public static string RunNonQuerySQL(string sqlCmd)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(cnnStr);
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sqlCmd;
                cmd.ExecuteNonQuery();
                return "True";
            }
            catch (Exception ex) {
                return ex.ToString();
            }
        }
    }
}
