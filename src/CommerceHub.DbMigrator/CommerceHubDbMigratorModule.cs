using CommerceHub.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CommerceHub.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CommerceHubEntityFrameworkCoreModule),
    typeof(CommerceHubApplicationContractsModule)
    )]
public class CommerceHubDbMigratorModule : AbpModule
{
}
