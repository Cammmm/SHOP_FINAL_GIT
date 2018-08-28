using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.DAO
{
    public class UserDAO
    {
        private DB1 db = null;
        public UserDAO()
        {
            db = new DB1();
        }
        public long Insert(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
            return u.ID;
        }

        public void Update(User u)
        {

        }

        public bool Login(string Email, string password)
        {
            var result = db.Users.Count(x => x.Email == Email && x.Password == password);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
