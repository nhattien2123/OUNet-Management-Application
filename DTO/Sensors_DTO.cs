using System;
using System.Collections.Generic;
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
        #endregion
    }
}
