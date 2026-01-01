using System.Threading.Tasks;

namespace CommerceHub.Data;

public interface ICommerceHubDbSchemaMigrator
{
    Task MigrateAsync();
}
