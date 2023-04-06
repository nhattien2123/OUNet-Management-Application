using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Messages_DTO
    {
        #region CacBienCuaProperty
        string _MessageID;
        string _Content;
        DateTime _Time;
        string _UserID;
        string _AdminID;
        string _UserSend;
        #endregion

        #region CacProperty
        public string MessageID
        {
            get { return _MessageID; }
            set { _MessageID = value; }
        }

        public string Content
        {
            get { return _Content; }
            set { _Content = value; }
        }

        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public string AdminID
        {
            get { return _AdminID; }
            set { _AdminID = value; }
        }

        public string UserSend
        {
            get { return _UserSend; }
            set { _UserSend = value; }
        }
        #endregion
    }
}
