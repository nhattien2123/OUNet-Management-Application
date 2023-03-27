using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailService_DTO
    {
        #region CacBienCuaProperty
        string _DetailServiceID;
        int _Quantity;
        string _Image;
        string _ServiceID;
        #endregion

        #region CacProperty
        public string DetailServiceID
        {
            get { return _DetailServiceID; }
            set { _DetailServiceID = value; }
        }

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        public string Image
        {
            get { return _Image; }
            set { _Image = value; }
        }

        public string ServiceID
        {
            get { return _ServiceID; }
            set { _ServiceID = value; }
        }
        #endregion
    }
}
