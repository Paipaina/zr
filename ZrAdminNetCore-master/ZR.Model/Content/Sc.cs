using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.Model.Content
{
    [SugarTable("sc")]
    [Tenant("0")]
    public class Sc
    {

        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        [Required]
        public string Sno { get; set; }
        [Required]
        public string Cno { get; set; }
        [Required]
        public string Score { get; set; }

    }
}
