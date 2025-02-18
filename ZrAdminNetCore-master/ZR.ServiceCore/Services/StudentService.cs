using Infrastructure.Attribute;
using Infrastructure.Extensions;
using ZR.Repository;
using ZR.ServiceCore;
using ZR.Model;
using ZR.ServiceCore.Services.IService;
using ZR.Model.Content.Dto;
using ZR.Model.Content;

namespace ZR.ServiceCore.Services
{
    /// <summary>
    /// Service业务层处理
    /// </summary>
    [AppService(ServiceType = typeof(IStudentService), ServiceLifetime = LifeTime.Transient)]
    public class StudentService : BaseService<Student>, IStudentService
    {
        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        public PagedInfo<StudentDto> GetList(StudentQueryDto parm)
        {
            var predicate = QueryExp(parm);

            var response = Queryable()
                .Where(predicate.ToExpression())
                .ToPage<Student, StudentDto>(parm);

            return response;
        }


        /// <summary>
        /// 获取详情
        /// </summary>
        /// <param name="Sno"></param>
        /// <returns></returns>
        public Student GetInfo(string Sno)
        {
            var response = Queryable()
                .Where(x => x.Sno == Sno)
                .First();

            return response;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Student AddStudent(Student model)
        {
            return Insertable(model).ExecuteReturnEntity();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateStudent(Student model)
        {
            return Update(model, true);
        }

        /// <summary>
        /// 查询导出表达式
        /// </summary>
        /// <param name="parm"></param>
        /// <returns></returns>
        private static Expressionable<Student> QueryExp(StudentQueryDto parm)
        {
            var predicate = Expressionable.Create<Student>();
            //完善查询条件
            if (!string.IsNullOrEmpty(parm.Sno))
                predicate = predicate.And(x => x.Sno.Contains(parm.Sno));
            if (!string.IsNullOrEmpty(parm.Sname))
                predicate = predicate.And(x => x.Sname.Contains(parm.Sname));
            return predicate;
        }

    }
}