using ZR.Model;
using ZR.Model.Content;
using ZR.Model.Content.Dto;

namespace ZR.ServiceCore.Services.IService
{
    /// <summary>
    /// service接口
    /// </summary>
    public interface ITeacherService : IBaseService<Teacher>
    {
        List<TeacherDto> GetTeacherList();

    }
}
