using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Services_DAO
    {
        // Hàm lấy danh sách dịch vụ
        public static List<Services_DTO> ListServices()
        {
            List<Services_DTO> ListServices = new List<Services_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL("SELECT * FROM dbo.Services");
            Services_DTO services;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                services = new Services_DTO();
                services.ServiceID = dt.Rows[i]["ServiceID"].ToString();
                services.ServiceName = dt.Rows[i]["ServiceName"].ToString();
                services.Price = dt.Rows[i]["Price"].ToString();
                ListServices.Add(services);
            }
            return ListServices;
        }
    }
}
