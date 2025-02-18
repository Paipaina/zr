namespace ZR.Model.Content
{
    /// <summary>
    /// 学生实体类，对应数据库中的 student 表
    /// </summary>
    [SugarTable("student")]
    [Tenant("0")]
    public class Student
    {
        /// <summary>
        /// 学号（Sno），为主键且不是自增列
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        [Required]
        public string Sno { get; set; }

        /// <summary>
        /// 学生姓名（Sname）
        /// </summary>
        public string Sname { get; set; }
        [Required]

        /// <summary>
        /// 学生性别（Ssex）
        /// </summary>
        public string Ssex { get; set; }
        [Required]

        /// <summary>
        /// 学生年龄（Sage）
        /// </summary>
        public string Sage { get; set; }

        /// <summary>
        /// 学生生日（Sbirthday），可为空
        /// </summary>
        public DateTime? Sbirthday { get; set; }

    }
}