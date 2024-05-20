using SiamMaintenance.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SiamMaintenance.Permissions;

public class SiamMaintenancePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SiamMaintenancePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SiamMaintenancePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SiamMaintenanceResource>(name);
    }
}
