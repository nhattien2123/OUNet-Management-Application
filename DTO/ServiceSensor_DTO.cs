using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ServiceSensor_DTO
    {
        #region CacBienCuaProperty
        [NotMapped]
        private string _ID;
        private string userID;
        private string userPhone;
        private int _Price;
        private string des;
        private DateTime time;
        private string namePCOrder;
        private List<OrderService_DTO> orderService;
        #endregion

        #region CacProperty
        public string UserID { get => userID; set => userID = value; }
        public string UserPhone { get => userPhone; set => userPhone = value; }
        public string Des { get => des; set => des = value; }
        public DateTime Time { get => time; set => time = value; }
        public string NamePCOrder { get => namePCOrder; set => namePCOrder = value; }
        public List<OrderService_DTO> OrderService { get => orderService; set => orderService = value; }
        public string ID { get => _ID; set => _ID = value; }
        public int Price { get => _Price; set => _Price = value; }

        #endregion
    }
}
