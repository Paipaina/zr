using Microsoft.AspNetCore.Mvc;
using ZR.ServiceCore.Services.IService;

//创建时间：2025-02-18
namespace ZR.Admin.WebApi.Controllers.Business
{
    /// <summary>
    /// 课程控制器
    /// </summary>
    //[Verify]
    [Authorize]
    [Route("business/Course")]
    public class CourseController : BaseController
    {
        /// <summary>
        /// 课程服务接口
        /// </summary>
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        /// <summary>
        /// 查询课程列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "course:list")]
        public IActionResult QueryCourseList()
        {
            var courseList = _courseService.GetCourseList();
            return SUCCESS(courseList);
        }
    }
}