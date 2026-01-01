using System;
using System.Collections.Generic;
using System.Text;
using CommerceHub.Localization;
using Volo.Abp.Application.Services;

namespace CommerceHub;

/* Inherit your application services from this class.
 */
public abstract class CommerceHubAppService : ApplicationService
{
    protected CommerceHubAppService()
    {
        LocalizationResource = typeof(CommerceHubResource);
    }
}
