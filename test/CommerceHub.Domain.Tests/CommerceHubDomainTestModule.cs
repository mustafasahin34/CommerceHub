using Volo.Abp.Modularity;

namespace CommerceHub;

[DependsOn(
    typeof(CommerceHubDomainModule),
    typeof(CommerceHubTestBaseModule)
)]
public class CommerceHubDomainTestModule : AbpModule
{

}
