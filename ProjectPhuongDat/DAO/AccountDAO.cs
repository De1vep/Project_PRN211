using ProjectPhuongDat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhuongDat.DAO
{
    internal class AccountDAO
    {
        public User GetUserByUsernameAndPassword(string username, string pass)
        {
            User user = new User();

            MusicStoreContext musicStoreContext = new MusicStoreContext();
            if (username != null && pass != null)
            {
                user = (from p in musicStoreContext.Users where p.UserName == username && p.Password == pass select p).ToList().FirstOrDefault();
            }

            return user;
        }
    }
}
