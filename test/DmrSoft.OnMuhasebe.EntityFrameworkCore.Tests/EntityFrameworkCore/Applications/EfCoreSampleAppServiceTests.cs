using DmrSoft.OnMuhasebe.Samples;
using Xunit;

namespace DmrSoft.OnMuhasebe.EntityFrameworkCore.Applications;

[Collection(OnMuhasebeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OnMuhasebeEntityFrameworkCoreTestModule>
{

}
