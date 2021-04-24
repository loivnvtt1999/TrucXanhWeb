using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGame
{
    public class tblUser
    {
        [Key]
        public int userID { get; set; }
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="Bạn phải nhập tên tài khoản")]
        public string userName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Bạn phải nhập email")]
        public string email { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Bạn phải nhập số điện thoại")]
        public string phone { get; set; }
        public bool role { get; set; }
        //public int? accountID { get; set; }
        //[ForeignKey("accountID")]
        //public virtual tblAccount Account { get; set; }
    }
}
