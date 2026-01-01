using CommerceHub.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CommerceHub.Permissions;

public class CommerceHubPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CommerceHubPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CommerceHubPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CommerceHubResource>(name);
    }
}
