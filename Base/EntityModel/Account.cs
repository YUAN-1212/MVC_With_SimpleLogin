using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.EntityModel
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [DisplayName("")]
        public int Index { get; set; }

        [DisplayName("帳號名字")]
        public string Name { get; set; }

        [DisplayName("密碼")]
        public string Password { get; set; }

        [DisplayName("創建日期")]
        public DateTime Createtime { get; set; }
    }
}
