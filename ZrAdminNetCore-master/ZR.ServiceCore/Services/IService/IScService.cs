using ZR.Model.Content;
using ZR.Model.Content.Dto;

namespace ZR.ServiceCore.Services.IService
{
    public interface IScService : IBaseService<Sc>
    {
        List<ScDto> GetScList();
    }
}
