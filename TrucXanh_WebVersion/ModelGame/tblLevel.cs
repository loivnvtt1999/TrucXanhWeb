using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGame
{
    public class tblLevel
    {
        [Key]
        public int levelID { get; set; }
        public string levelName { get; set; }
    }
}
