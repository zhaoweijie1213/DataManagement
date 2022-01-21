using DataManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DataManagement.Permissions;

public class DataManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DataManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DataManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DataManagementResource>(name);
    }
}
