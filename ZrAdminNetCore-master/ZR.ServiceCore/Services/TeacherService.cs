using Infrastructure.Attribute;
using ZR.Model.Content;
using ZR.Model.Content.Dto;
using ZR.ServiceCore.Services.IService;

namespace ZR.ServiceCore.Services
{
    /// <summary>
    /// Service业务层处理
    /// </summary>
    [AppService(ServiceType = typeof(ITeacherService), ServiceLifetime = LifeTime.Transient)]
    public class TeacherService : BaseService<Teacher>, ITeacherService
    {
        public List<TeacherDto> GetTeacherList()
        {
            var teacher = Queryable().ToList();

            var teacherDtos = teacher.Select(teacher => new TeacherDto
            {
                Tno = teacher.Tno,
                Tname = teacher.Tname,
            }).ToList();
            return teacherDtos;
        }
    }
}