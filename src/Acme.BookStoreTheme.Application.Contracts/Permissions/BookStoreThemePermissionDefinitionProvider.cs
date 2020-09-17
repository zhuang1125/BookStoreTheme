using Acme.BookStoreTheme.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStoreTheme.Permissions
{
    public class BookStoreThemePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BookStoreThemePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(BookStoreThemePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreThemeResource>(name);
        }
    }
}
