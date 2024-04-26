using Volo.Abp.Modularity;

namespace DmrSoft.OnMuhasebe;

public abstract class OnMuhasebeApplicationTestBase<TStartupModule> : OnMuhasebeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
