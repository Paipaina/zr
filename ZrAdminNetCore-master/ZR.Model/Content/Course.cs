using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.Model.Content
{
    [SugarTable("course")]
    [Tenant("0")]
    public class Course
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        [Required]
        public string Cno { get; set; }
        [Required]
        public string Cname { get; set; }
        [Required]
        public string Tno { get; set; }
    }
}
