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
    public class OrderService_DTO
    {
        [NotMapped]
        #region CacBienCuaProperty
        string _ServiceID;
        string _ServiceName;

        int _ServiceQuantity;
        int _ServicePrice;
        int _ServiceTotal;

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

        public int ServiceQuantity
        {
            get { return _ServiceQuantity; }
            set { _ServiceQuantity = value; }
        }

        public int ServicePrice { get => _ServicePrice; set => _ServicePrice = value; }
        public int ServiceTotal { get => _ServicePrice * _ServiceQuantity; }
        #endregion
    }
}
