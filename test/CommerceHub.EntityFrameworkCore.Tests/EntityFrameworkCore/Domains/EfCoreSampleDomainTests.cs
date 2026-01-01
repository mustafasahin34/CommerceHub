using CommerceHub.Samples;
using Xunit;

namespace CommerceHub.EntityFrameworkCore.Domains;

[Collection(CommerceHubTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CommerceHubEntityFrameworkCoreTestModule>
{

}
