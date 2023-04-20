using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill_DTO
    {
        #region CacBienCuaProperty
        string _BillID;
        string _HistoryID;
        string _ServiceID;
        int _Quantity;
        int _Total;
        #endregion

        #region CacProperty
        public string BillID
        {
            get { return _BillID; }
            set { _BillID = value; }
        }

        public string HistoryID
        {
            get { return _HistoryID; }
            set { _HistoryID = value; }
        }

        public string ServiceID
        {
            get { return _ServiceID; }
            set { _ServiceID = value; }
        }

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        public int Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        #endregion
    }
}
