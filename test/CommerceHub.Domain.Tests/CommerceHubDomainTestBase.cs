using Volo.Abp.Modularity;

namespace CommerceHub;

/* Inherit from this class for your domain layer tests. */
public abstract class CommerceHubDomainTestBase<TStartupModule> : CommerceHubTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
