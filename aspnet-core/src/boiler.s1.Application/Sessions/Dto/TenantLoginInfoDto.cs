using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using boiler.s1.MultiTenancy;

namespace boiler.s1.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
