using Volo.Abp.Modularity;

namespace CommerceHub;

public abstract class CommerceHubApplicationTestBase<TStartupModule> : CommerceHubTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
