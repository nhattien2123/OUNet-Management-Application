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
            DataTable dt = ProcessingDAO.RunQuerySQL($"SELECT s.SensorID, s.SensorName, s.AddressIP, s.Status, u.Tel, MAX(sd.TimeStart) AS TimeStart, sd.TimeEnd FROM Sensors s LEFT JOIN SensorsDetails sd ON s.SensorID = sd.SensorID LEFT JOIN Users u ON sd.UserID = u.UserID GROUP BY s.SensorID, s.SensorName, s.AddressIP, s.Status, u.Tel, sd.TimeEnd ORDER BY s.SensorID");
            Sensors_DTO sensor;
            for (int i = 0; i < dt.Rows.Count; i++) {
                sensor = new Sensors_DTO();
                sensor.SensorID = dt.Rows[i]["SensorID"].ToString();
                sensor.SensorName = dt.Rows[i]["SensorName"].ToString();
                sensor.AddressIP = dt.Rows[i]["AddressIP"].ToString();
                sensor.Status = dt.Rows[i]["Status"].ToString() == "1" ? "- - -" : "Đang hoạt động";
                if (!String.IsNullOrEmpty(dt.Rows[i]["TimeEnd"].ToString()) && String.IsNullOrEmpty(dt.Rows[i]["TimeStart"].ToString()))
                {
                    sensor.Utel = "- - -";
                    sensor.TimeStart = "- - -";
                   
                }
                else {
                    sensor.Utel = dt.Rows[i]["Tel"].ToString();
                    sensor.TimeStart = dt.Rows[i]["TimeStart"].ToString().Trim();
                    
                }
                listSensors.Add(sensor);
            }
            return listSensors;
        }

        public static string FindAndCreateSensor(string userID, string sName, string sIP)
        {
            
            string sqlcmd = $"select SensorID from Sensors where SensorName = N'{sName}' and AddressIP = N'{sIP}'";
            DataTable dt = ProcessingDAO.RunQuerySQL(sqlcmd);
            
            Boolean existed = dt?.Rows.Count >= 1 ? true : false;
            if (existed)
            {
                string val = dt.Rows[0]["SensorID"].ToString();
                {
                    string sqlCmd = $"DECLARE @currDate DATETIME; SET @currDate = GETDATE(); UPDATE Sensors SET Status = 1 Where SensorID = N'{val}'; INSERT INTO SensorsDetails (SensorID, UserID, TimeStart, TimeEnd) VALUES(N'{val}', N'{userID}', @currDate, null);";
                    return ProcessingDAO.RunNonQuerySQL(sqlCmd);
                };
            }
            if (!existed)
            {
                string sqlCmd = $"DECLARE @currDate DATETIME; SET @currDate = GETDATE(); INSERT INTO Sensors (SensorName, AddressIP, Status) VALUES (N'{sName}', N'{sIP}', 1); INSERT INTO SensorsDetails (SensorID, UserID, TimeStart, TimeEnd) VALUES(SCOPE_IDENTITY(), N'{userID}', @currDate, null);";
                return ProcessingDAO.RunNonQuerySQL(sqlCmd);
            }
            return "fail";

        }

        public static string FindAndLogoutSensor(string userID, string sName, string sIP)
        {

            string sqlcmd = $"select SensorID from Sensors where SensorName = N'{sName}' and AddressIP = N'{sIP}'";
            DataTable dt = ProcessingDAO.RunQuerySQL(sqlcmd);

            Boolean existed = dt?.Rows.Count >= 1 ? true : false;
            if (existed)
            {
                string val = dt.Rows[0]["SensorID"].ToString();
                {
                    string sqlCmd = $"DECLARE @currDate DATETIME; SET @currDate = GETDATE(); UPDATE Sensors SET Status = 1 Where SensorID = N'{val}'; INSERT INTO SensorsDetails (SensorID, UserID, TimeStart, TimeEnd) VALUES(N'{val}', N'{userID}', @currDate, null);";
                    return ProcessingDAO.RunNonQuerySQL(sqlCmd);
                };
            }
            return "fail";

        }
    }
}
