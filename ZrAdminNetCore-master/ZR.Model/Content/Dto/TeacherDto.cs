namespace ZR.Model.Content.Dto
{

    /// <summary>
    /// 输入输出对象
    /// </summary>
    public class TeacherDto
    {
        [Required(ErrorMessage = "Tno不能为空")]
        public string Tno { get; set; }
        [Required(ErrorMessage = "老师不能为空")]
        public string Tname { get; set; }



    }
}