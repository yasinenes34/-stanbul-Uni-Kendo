using IstanbulUniKendo.BAL.Abstract;
using IstanbulUniKendo.DAL.Abstract;
using IstanbulUniKendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUniKendo.BAL.Concrate
{
    internal class UserManager : IUserService
    {
        IUser _user;
        public List<User> GetListBl()
        {
            return _user.List();
        }

        public bool UserAddBl(User user)
        {
            var _userInfo = _user.get(t => t.Email == user.Email && t.Password == user.Password);
            if (_userInfo != null)
            {
                return false;
            }
            else { _user.Insert(user); return true; }
        }

        public bool UserLogin(User user)
        {
            var userInfo = _user.get(t => t.Email == user.Email && t.Password == user.Password);
            if (userInfo != null)
                return true;
            else return false;
        }
    }
}
