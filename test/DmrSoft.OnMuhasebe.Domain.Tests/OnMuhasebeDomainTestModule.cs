using Volo.Abp.Modularity;

namespace DmrSoft.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeDomainModule),
    typeof(OnMuhasebeTestBaseModule)
)]
public class OnMuhasebeDomainTestModule : AbpModule
{

}
