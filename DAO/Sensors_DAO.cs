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
            DataTable dt = ProcessingDAO.RunQuerySQL($"SELECT ds.SensorID, SensorName, AddressIP, Sensors.Status, Tel, ds.TimeStart, ds.TimeEnd FROM SensorsDetails ds INNER JOIN(SELECT SensorID, MAX(TimeStart) AS MaxTimeStart FROM SensorsDetails WHERE SensorID IN(SELECT SensorID from Sensors) GROUP BY SensorID) ds_max ON ds.SensorID = ds_max.SensorID AND ds.TimeStart = ds_max.MaxTimeStart LEFT JOIN Users ON Users.UserID = ds.UserID LEFT JOIN Sensors ON Sensors.SensorID = ds.SensorID order by SensorID");
            Sensors_DTO sensor;
            for (int i = 0; i < dt.Rows.Count; i++) {
                sensor = new Sensors_DTO();
                sensor.SensorID = dt.Rows[i]["SensorID"].ToString();
                sensor.SensorName = dt.Rows[i]["SensorName"].ToString();
                sensor.AddressIP = dt.Rows[i]["AddressIP"].ToString();
                sensor.Status = Boolean.Parse(dt.Rows[i]["Status"].ToString()) == false ? "- - -" : "Đang hoạt động";
                Boolean isTimeEndNull = String.IsNullOrEmpty(dt.Rows[i]["TimeEnd"].ToString());
                if (isTimeEndNull)
                {
                    sensor.Utel = dt.Rows[i]["Tel"].ToString();
                    sensor.TimeStart = dt.Rows[i]["TimeStart"].ToString().Trim();
                }
                else {
                    sensor.Utel = "- - -";
                    sensor.TimeStart = "- - -";
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
                    string sqlCmd = $"DECLARE @currDate DATETIME; SET @currDate = GETDATE(); UPDATE Sensors SET Status = 0 Where SensorID = {val}; UPDATE SensorsDetails SET TimeEnd = @currDate FROM (SELECT TOP 1 SensorDetailID FROM SensorsDetails WHERE SensorID = {val} ORDER BY TimeStart DESC) as a WHERE SensorsDetails.SensorDetailID = a.SensorDetailID";
                    return ProcessingDAO.RunNonQuerySQL(sqlCmd);
                };
            }
            return "fail";

        }
    }
}
