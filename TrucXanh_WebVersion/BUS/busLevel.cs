using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ModelGame;
namespace BUS
{
    public class busLevel
    {
        TrucXanhDbContext db = new TrucXanhDbContext();
        public tblLevel getFirstLevel()
        {
            return db.Levels.FirstOrDefault();
        }
    }
}
