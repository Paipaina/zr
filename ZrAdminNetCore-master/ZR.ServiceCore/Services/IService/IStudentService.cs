using ZR.Model;
using ZR.ServiceCore;
using ZR.Model.Content.Dto;
using ZR.Model.Content;

namespace ZR.ServiceCore.Services.IService
{
    /// <summary>
    /// service接口
    /// </summary>
    public interface IStudentService : IBaseService<Student>
    {
        PagedInfo<StudentDto> GetList(StudentQueryDto parm);

        Student GetInfo(string Sno);


        Student AddStudent(Student parm);
        int UpdateStudent(Student parm);


    }
}
