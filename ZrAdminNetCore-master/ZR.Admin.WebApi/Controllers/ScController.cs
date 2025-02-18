using Microsoft.AspNetCore.Mvc;
using ZR.ServiceCore.Services.IService;

namespace ZR.Admin.WebApi.Controllers.Business
{
    /// <summary>
    /// Sc控制器
    /// </summary>
    //[Verify]
    [Authorize]
    [Route("business/Sc")]
    public class ScController : BaseController
    {
        /// <summary>
        /// Sc服务接口
        /// </summary>
        private readonly IScService _scService;

        public ScController(IScService scService)
        {
            _scService = scService;
        }

        /// <summary>
        /// 查询Sc列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("list")]
        [ActionPermissionFilter(Permission = "sc:list")]
        public IActionResult QueryScList()
        {
            var scList = _scService.GetScList();
            return SUCCESS(scList);
        }
    }
}