using CommerceHub.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CommerceHub.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CommerceHubPageModel : AbpPageModel
{
    protected CommerceHubPageModel()
    {
        LocalizationResourceType = typeof(CommerceHubResource);
    }
}
