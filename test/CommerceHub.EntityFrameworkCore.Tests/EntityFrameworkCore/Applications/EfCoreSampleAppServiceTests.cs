using CommerceHub.Samples;
using Xunit;

namespace CommerceHub.EntityFrameworkCore.Applications;

[Collection(CommerceHubTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CommerceHubEntityFrameworkCoreTestModule>
{

}
