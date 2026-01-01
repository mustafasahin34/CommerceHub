using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace CommerceHub.Pages;

public class Index_Tests : CommerceHubWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
