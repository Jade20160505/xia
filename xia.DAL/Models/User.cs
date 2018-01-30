using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace xia.DAL.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int USR_ID { get; set; }
        public string USR_NAME { get; set; }
        public string USR_SEX { get; set; }
        public int USR_LILIANG { get; set; }
        public int USR_MINJIE { get; set; }
        public string USR_WUXING { get; set; }
        public int USR_LEVEL { get; set; }
        public int USR_EXP { get; set; }
        public int USR_NEXT_LEVEL { get; set; }
        public int USR_MONEY { get; set; }
        public int USR_CUR_HP { get; set; }
        public int USR_MAX_HP { get; set; }
        public int USR_CUR_MP { get; set; }
        public int USR_MAX_MP { get; set; }
    }
}
