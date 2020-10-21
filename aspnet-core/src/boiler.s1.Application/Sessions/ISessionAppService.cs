using System.Threading.Tasks;
using Abp.Application.Services;
using boiler.s1.Sessions.Dto;

namespace boiler.s1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
