using DmrSoft.OnMuhasebe.Samples;
using Xunit;

namespace DmrSoft.OnMuhasebe.EntityFrameworkCore.Domains;

[Collection(OnMuhasebeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OnMuhasebeEntityFrameworkCoreTestModule>
{

}
