using Microsoft.AspNetCore.Mvc;
using ZR.Admin.WebApi.Filters;
using ZR.Model.Content;
using ZR.Model.Content.Dto;
using ZR.ServiceCore.Services.IService;

namespace ZR.Admin.WebApi.Controllers.Business  
{
    /// <summary>
    /// 
    /// </summary>
    //[Verify]
    [Authorize]
    [Route("business/Teacher")]
    public class TeacherController : BaseController
    {
        /// <summary>
        /// 接口
        /// </summary>
        private readonly ITeacherService _TeacherService;

        public TeacherController(ITeacherService TeacherService)
        {
            _TeacherService = TeacherService;
        }

        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "teacher:list")]
        public IActionResult QueryTeacher()
        {
            var response = _TeacherService.GetList();
            return SUCCESS(response);
        }

    }
}