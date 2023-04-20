using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class History_DTO
    {
        #region CacBienCuaProperty
        string _HistoryID;
        string _UserID;
        string _AdminID;
        string _Description;
        DateTime _Time;
        #endregion

        #region CacProperty
        public string HistoryID
        {
            get { return _HistoryID; }
            set { _HistoryID = value; }
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

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        #endregion
    }
}
