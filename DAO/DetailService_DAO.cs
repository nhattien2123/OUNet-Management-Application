using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DetailService_DAO
    {
        // Hàm lấy danh sách chi tiết dịch vụ
        public static List<DetailService_DTO> ListDetailService()
        {
            List<DetailService_DTO> listDetailService = new List<DetailService_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL("SELECT * FROM dbo.DetailService");
            DetailService_DTO detailService;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                detailService = new DetailService_DTO();
                detailService.DetailServiceID = dt.Rows[i]["DetailServiceID"].ToString();
                detailService.Quantity = int.Parse(dt.Rows[i]["Quantity"].ToString());
                detailService.Image = dt.Rows[i]["Image"].ToString();
                detailService.ServiceID = dt.Rows[i]["ServiceID"].ToString();
                listDetailService.Add(detailService);
            }
            return listDetailService;
        }
    }
}
