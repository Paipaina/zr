using Microsoft.AspNetCore.Mvc;
using ZR.Admin.WebApi.Filters;
using ZR.ServiceCore.Services.IService;
using ZR.Model.Content.Dto;
using ZR.Model.Content;

//创建时间：2025-02-07
namespace ZR.Admin.WebApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    //[Verify]
    [Authorize]
    [Route("business/Student")]
    public class StudentController : BaseController
    {
        /// <summary>
        /// 接口
        /// </summary>
        private readonly IStudentService _StudentService;

        public StudentController(IStudentService StudentService)
        {
            _StudentService = StudentService;
        }

        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "student:list")]
        public IActionResult QueryStudent([FromQuery] StudentQueryDto parm)
        {
            var response = _StudentService.GetList(parm);
            return SUCCESS(response);
        }


        /// <summary>
        /// 查询详情
        /// </summary>
        /// <param name="Sno"></param>
        /// <returns></returns>
        [HttpGet("{Sno}")]
        [ActionPermissionFilter(Permission = "student:query")]
        public IActionResult GetStudent(string Sno)
        {
            var response = _StudentService.GetInfo(Sno);

            var info = response.Adapt<StudentDto>();
            return SUCCESS(info);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ActionPermissionFilter(Permission = "student:add")]
        [Log(Title = "", BusinessType = BusinessType.INSERT)]
        public IActionResult AddStudent([FromBody] StudentDto parm)
        {
            var modal = parm.Adapt<Student>().ToCreate(HttpContext);

            var response = _StudentService.AddStudent(modal);

            return SUCCESS(response);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ActionPermissionFilter(Permission = "student:edit")]
        [Log(Title = "", BusinessType = BusinessType.UPDATE)]
        public IActionResult UpdateStudent([FromBody] StudentDto parm)
        {
            var modal = parm.Adapt<Student>().ToUpdate(HttpContext);
            var response = _StudentService.UpdateStudent(modal);

            return ToResponse(response);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        [HttpPost("delete/{ids}")]
        [ActionPermissionFilter(Permission = "student:delete")]
        [Log(Title = "", BusinessType = BusinessType.DELETE)]
        public IActionResult DeleteStudent([FromRoute] string ids)
        {
            var idArr = Tools.SplitAndConvert<string>(ids);

            return ToResponse(_StudentService.Delete(idArr));
        }

    }
}