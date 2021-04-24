using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelGame;
using DAL;
namespace BUS
{
    public class busAccounts
    {
        TrucXanhDbContext db = new TrucXanhDbContext();
        public tblAccount checkLogin(tblAccount account)
        {
            tblAccount checkAccount = db.Accounts.Where(x => x.nameAccount.Equals(account.nameAccount) && account.password.Equals(account.password)).FirstOrDefault();
            if (checkAccount != null)
                return checkAccount;
            else
                return null;
        }
    }
}
