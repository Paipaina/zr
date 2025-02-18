namespace ZR.Model.Content.Dto
{
    public class StudentQueryDto : PagerInfo
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
    }
    /// <summary>
    /// 输入输出对象
    /// </summary>
    public class StudentDto
    {
        [Required(ErrorMessage = "Sno不能为空")]
        public string Sno { get; set; }

        [Required(ErrorMessage = "Sname不能为空")]
        public string Sname { get; set; }

        [Required(ErrorMessage = "Ssex不能为空")]

        public int? Sage { get; set; }
        public string Ssex { get; set; }

        public DateTime? Sbirthday { get; set; }

    }


}