using System.Threading.Tasks;

namespace DataManagement.Data;

public interface IDataManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
