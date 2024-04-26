using System.Threading.Tasks;

namespace DmrSoft.OnMuhasebe.Data;

public interface IOnMuhasebeDbSchemaMigrator
{
    Task MigrateAsync();
}
