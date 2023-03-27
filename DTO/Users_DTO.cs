using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Users_DTO
    {
        #region CacBienCuaProperty
        private string _UserID;
        private string _Username;
        private string _Tel;
        private string _Password;
        private string _Address;
        private string _Role;
        private float _M_Account;
        private float _S_Account;
        private DateTime _LastAccess;
        private bool _Status;
        private string _Nation;
        private string _Sex;
        private string _HomeTown;
        private DateTime _BirthDay;
        #endregion

        #region CacProperty
        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string Tel
        {
            get { return _Tel; }
            set { _Tel = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Role
        {
            get { return _Role; }
            set { _Role = value; }
        }

        public float M_Account
        {
            get { return _M_Account; }
            set { _M_Account = value; }
        }

        public float S_Account
        {
            get { return _S_Account; }
            set { _S_Account = value; }
        }

        public DateTime LastAccess
        {
            get { return _LastAccess; }
            set { _LastAccess = value; }
        }

        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string Nation
        {
            get { return _Nation; }
            set { _Nation = value; }
        }

        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        public string HomeTown
        {
            get { return _HomeTown; }
            set { _HomeTown = value; }
        }

        public DateTime BirthDay
        {
            get { return _BirthDay; }
            set { _BirthDay = value; }
        }
        #endregion
    }
}
