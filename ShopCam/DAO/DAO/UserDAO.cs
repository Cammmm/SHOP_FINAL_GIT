using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.EF;
using PagedList;
namespace DAO.DAO
{
    public class UserDAO
    {
        private EntityDB db = null;
        public UserDAO()
        {
            db = new EntityDB();
        }
        public User GetbyID(string userName)
        {
            return db.Users.SingleOrDefault(x => x.Username == userName);
        }

        public User ViewDetail (string id)
        {
            return db.Users.Find(id);
        }

        #region Insert-Delete-Update
        //--------------Insert------------------
        public string Insert(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
            return u.Username;
        }
        //--------------Edit------------------
        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.ID = entity.ID;
                user.Password = entity.Password;
                user.Fullname = entity.Fullname;
                user.Remember_token = entity.Remember_token;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
        //--------------Delete------------------
        public bool Delete(string id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        #endregion


        #region Login
        public bool LoginB(string Username, string password)
        {
            var result = db.Users.Count(x => x.Username == Username && x.Password == password);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        public int Login(string Username, string password)
        {

            var result = db.Users.SingleOrDefault(x => x.Username == Username);
            if (result == null)
            {
                //return "Username không tồn tại.";
                return 0; // Sai username
            }
            else
            {
                if (result.Password == password)
                {
                    return 1; // Đúng mật khẩu + id
                }
                else
                {
                    return -1; // Đúng mật khẩu sai id
                }
            }
        }
        #endregion


        #region Phan trang
        public IEnumerable<User> ListALl(string txtSearch,int page, int pageSize)
        {
            IQueryable<User> model = db.Users;
            //var model = db.Users.OrderByDescending(x => x.ID);
            if (!string.IsNullOrEmpty(txtSearch))
            {
                model = model.Where(x => x.Username.Contains(txtSearch) || x.Fullname.Contains(txtSearch));
            }
            //return db.Users.OrderByDescending(l => l.ID).ToPagedList(page, pageSize);
            return model.OrderByDescending(x => x.ID).ToPagedList(page, pageSize);
        }
        #endregion




    }
}
