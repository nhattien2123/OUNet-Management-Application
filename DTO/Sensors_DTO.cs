using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sensors_DTO
    {
        #region CacBienCuaProperty
        string _SensorID;
        string _SensorName;
        string _AddressIP;
        string _Status;

        [NotMapped]
        string _UTel;
        string _TimeStart;
        string _TimePlayed;
        string _TimeEnd;

        #endregion

        #region CacProperty
        public string SensorID
        {
            get { return _SensorID; }
            set { _SensorID = value; }
        }

        public string SensorName
        {
            get { return _SensorName; }
            set { _SensorName = value; }
        }

        public string AddressIP
        {
            get { return _AddressIP; }
            set { _AddressIP = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string Utel
        {
            get { return _UTel; }
            set { _UTel = value; }
        }

        public string TimeStart
        {
            get { return _TimeStart; }
            set { _TimeStart = value; }
        }
        public string TimePlayed
        {
            get {
                try
                {
                    if (!String.IsNullOrEmpty(_TimeStart))
                    {
                        string time = _TimeStart;

                        DateTime date = DateTime.ParseExact(time, "dd/MM/yyyy h:mm:ss tt", null);
                        DateTime now = DateTime.Now;
                        TimeSpan timeDiff = now.Subtract(date);
                        string hours = $"{(int)timeDiff.TotalHours}";
                        string minutes = $"{(int)timeDiff.TotalMinutes % 60}";
                        return $"{hours}:{minutes}";

                    }
                    return "- - -";
                }
                catch {
                    return "- - -";
                }
               
            }
        }

        public string TimeEnd
        {
            get { return _TimeEnd; }
            set { _TimeEnd = value; }
        }
        #endregion
    }
}
