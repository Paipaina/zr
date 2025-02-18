using Infrastructure.Attribute;
using ZR.Model.Content;
using ZR.Model.Content.Dto;
using ZR.ServiceCore.Services.IService;

namespace ZR.ServiceCore.Services
{
    [AppService(ServiceType = typeof(ICourseService), ServiceLifetime = LifeTime.Transient)]
        public class CourseService : BaseService<Course>, ICourseService
        {
            /// <summary>
            /// 获取课程列表
            /// </summary>
            /// <returns></returns>
            public List<CourseDto> GetCourseList()
            {
                var courses = Queryable().ToList();
                var courseDtos = courses.Select(course => new CourseDto
                {
                    Cno = course.Cno,
                    Cname = course.Cname,
                    Tno = course.Tno
                }).ToList();
                return courseDtos;
            }


        }
    
    
}
