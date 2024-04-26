using DmrSoft.OnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace DmrSoft.OnMuhasebe.Blazor;

public abstract class OnMuhasebeComponentBase : AbpComponentBase
{
    protected OnMuhasebeComponentBase()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}
