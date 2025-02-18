namespace ZR.Model.Content
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("teacher")]
    [Tenant("0")]
    public class Teacher
    {
        /// <summary>
        /// Tno 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = false)]
        [Required]
        public string Tno { get; set; }


        /// <summary>
        /// Tname 
        /// </summary>
        [Required]
        public string Tname { get; set; }

    }
}