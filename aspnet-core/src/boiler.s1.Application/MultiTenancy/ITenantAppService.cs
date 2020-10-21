using Abp.Application.Services;
using boiler.s1.MultiTenancy.Dto;

namespace boiler.s1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

