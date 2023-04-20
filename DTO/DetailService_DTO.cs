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
        string _DetailServiceId;
        int _Quantity;
        string _Image;
        string _ServiceId;
        #endregion

        #region CacProperty
        public string DetailServiceId
        {
            get { return _DetailServiceId; }
            set { _DetailServiceId = value; }
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

        public string ServiceId
        {
            get { return _ServiceId; }
            set { _ServiceId = value; }
        }
        #endregion
    }
}
