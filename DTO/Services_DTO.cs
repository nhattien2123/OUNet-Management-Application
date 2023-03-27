using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Services_DTO
    {
        #region CacBienCuaProperty
        string _ServiceID;
        string _ServiceName;
        string _Price;
        #endregion

        #region CacProperty
        public string ServiceID
        {
            get { return _ServiceID; }
            set { _ServiceID = value; }
        }

        public string ServiceName
        {
            get { return _ServiceName; }
            set { _ServiceName = value; }
        }

        public string Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        #endregion
    }
}
