using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZR.Model.Content.Dto
{
    public class CourseDto
    {
        /// <summary>
        /// 课程编号（cno），不能为空
        /// </summary>
        [Required(ErrorMessage = "课程编号不能为空")]
        public string Cno { get; set; }

        /// <summary>
        /// 课程名字（cname），不能为空
        /// </summary>
        [Required(ErrorMessage = "课程名字不能为空")]
        public string Cname { get; set; }

        /// <summary>
        /// 代课老师（tname），不能为空
        /// </summary>
        [Required(ErrorMessage = "代课老师不能为空")]
        public string Tno{ get; set; }
    }
}
