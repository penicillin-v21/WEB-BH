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
        // init Connection string
        DemoDbContext db = null;
        
       public UserDAO()
        {
            db = new DemoDbContext();
        }

        // Insert a user
        public int Insert(USER user)
        {
            db.USERS.Add(user);
            db.SaveChanges();
            return user.Id;
        }

        // check login
        public bool CheckLogin(string userName, string passWord)
        {
            var res = db.USERS.Count(x => x.UserName == userName && x.Password == passWord);
            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Get id user
        public USER GetById(string userName)
        {
            return db.USERS.SingleOrDefault(x => x.UserName == userName);
        }



    }
}
