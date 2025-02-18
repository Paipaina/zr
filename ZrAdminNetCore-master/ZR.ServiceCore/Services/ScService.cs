using Infrastructure.Attribute;
using ZR.Model.Content;
using ZR.Model.Content.Dto;
using ZR.ServiceCore.Services.IService;

namespace ZR.ServiceCore.Services
{
    [AppService(ServiceType = typeof(IScService), ServiceLifetime = LifeTime.Transient)]
        public class ScService : BaseService<Sc>, IScService
        {
            /// <summary>
            /// 获取课程列表
            /// </summary>
            /// <returns></returns>
            public List<ScDto> GetScList()
            {
                var sc = Queryable().ToList();
                var scDtos = sc.Select(sc => new ScDto
                {
                    Sno = sc.Sno,
                    Cno = sc.Cno,
                    Score = sc.Score,
                }).ToList();
                return scDtos;
            }
        }
}
