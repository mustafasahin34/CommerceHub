using Xunit;

namespace CommerceHub.EntityFrameworkCore;

[CollectionDefinition(CommerceHubTestConsts.CollectionDefinitionName)]
public class CommerceHubEntityFrameworkCoreCollection : ICollectionFixture<CommerceHubEntityFrameworkCoreFixture>
{

}
