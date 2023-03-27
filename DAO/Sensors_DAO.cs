using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class Sensors_DAO
    {
        // Hàm lấy danh sách máy trạm
        public static List<Sensors_DTO> ListSensors()
        {
            List<Sensors_DTO> listSensors = new List<Sensors_DTO>();
            DataTable dt = ProcessingDAO.RunQuerySQL("SELECT * FROM dbo.Sensors");
            Sensors_DTO sensor;
            for (int i = 0; i < dt.Rows.Count; i++) {
                sensor = new Sensors_DTO();
                sensor.SensorID = dt.Rows[i]["SensorID"].ToString();
                sensor.SensorName = dt.Rows[i]["SensorName"].ToString();
                sensor.AddressIP = dt.Rows[i]["AddressIP"].ToString();
                listSensors.Add(sensor);
            }
            return listSensors;
        }

        // Hàm thêm một máy trạm
        public static string AddSensor(Sensors_DTO sensor)
        {
            string sqlCmd = string.Format("INSERT INTO dbo.Sensors (N'{0}', N'{1}', N'{2}')", sensor.SensorID, sensor.SensorName, sensor.AddressIP);
            return ProcessingDAO.RunNonQuerySQL(sqlCmd);
        }

        // Hàm sửa thông tin máy trạm
        //public static string EditSensor(Sensors_DTO sensor, string LastSensorID)
        //{
        //    string GanCacThuocTinh = "";
        //}
    }
}
