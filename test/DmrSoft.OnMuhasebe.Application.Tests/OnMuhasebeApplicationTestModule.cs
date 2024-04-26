using Volo.Abp.Modularity;

namespace DmrSoft.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeApplicationModule),
    typeof(OnMuhasebeDomainTestModule)
)]
public class OnMuhasebeApplicationTestModule : AbpModule
{

}
