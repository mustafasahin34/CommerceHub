using Volo.Abp.Modularity;

namespace CommerceHub;

[DependsOn(
    typeof(CommerceHubApplicationModule),
    typeof(CommerceHubDomainTestModule)
)]
public class CommerceHubApplicationTestModule : AbpModule
{

}
