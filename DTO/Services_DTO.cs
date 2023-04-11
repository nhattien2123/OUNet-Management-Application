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
    public class Services_DTO
    {
        #region CacBienCuaProperty
        string _ServiceID;
        string _ServiceName;
        string _Price;
        [NotMapped]
        string _ServiceImage;
        string _ServiceQuantity;
        
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

        public string ServiceImage { get => _ServiceImage; set => _ServiceImage = value; }
        public string ServiceQuantity { get => _ServiceQuantity; set => _ServiceQuantity = value; }
        #endregion
        
    }
}
