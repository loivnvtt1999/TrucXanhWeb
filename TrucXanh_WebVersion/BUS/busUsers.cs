using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelGame;
using DAL;
namespace BUS
{
    public class busUsers
    {
        TrucXanhDbContext db = new TrucXanhDbContext();
        public int insertUser(tblUser user)
        {
            tblUser checkUser = db.Users.Where(x => x.phone.Equals(user.phone) || x.email.Equals(user.email)).FirstOrDefault();
            if (checkUser != null)
                return 0;
            db.Users.Add(user);
            db.SaveChanges();
            return 1;
        }
    }
}
