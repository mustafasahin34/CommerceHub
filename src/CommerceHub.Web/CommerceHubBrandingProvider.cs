using Microsoft.Extensions.Localization;
using CommerceHub.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CommerceHub.Web;

[Dependency(ReplaceServices = true)]
public class CommerceHubBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CommerceHubResource> _localizer;

    public CommerceHubBrandingProvider(IStringLocalizer<CommerceHubResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
