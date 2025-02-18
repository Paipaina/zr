using ZR.Model.Content;
using ZR.Model.Content.Dto;

namespace ZR.ServiceCore.Services.IService
{
    /// <summary>
    /// 课程服务接口
    /// </summary>
    public interface ICourseService : IBaseService<Course>
        {
            /// <summary>
            /// 获取课程列表
            /// </summary>
            /// <returns></returns>
            List<CourseDto> GetCourseList();
        }
    
}
