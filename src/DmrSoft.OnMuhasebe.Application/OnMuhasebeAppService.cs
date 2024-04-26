using System;
using System.Collections.Generic;
using System.Text;
using DmrSoft.OnMuhasebe.Localization;
using Volo.Abp.Application.Services;

namespace DmrSoft.OnMuhasebe;

/* Inherit your application services from this class.
 */
public abstract class OnMuhasebeAppService : ApplicationService
{
    protected OnMuhasebeAppService()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}
