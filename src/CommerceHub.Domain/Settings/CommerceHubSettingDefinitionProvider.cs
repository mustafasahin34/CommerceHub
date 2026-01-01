using Volo.Abp.Settings;

namespace CommerceHub.Settings;

public class CommerceHubSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CommerceHubSettings.MySetting1));
    }
}
