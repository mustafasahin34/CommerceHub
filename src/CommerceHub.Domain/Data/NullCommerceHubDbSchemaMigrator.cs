using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CommerceHub.Data;

/* This is used if database provider does't define
 * ICommerceHubDbSchemaMigrator implementation.
 */
public class NullCommerceHubDbSchemaMigrator : ICommerceHubDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
