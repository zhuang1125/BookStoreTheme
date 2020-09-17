using EasyAbp.PrivateMessaging;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace Acme.BookStoreTheme
{
    [DependsOn(
        typeof(BookStoreThemeDomainSharedModule),
        typeof(AbpAccountApplicationContractsModule),
        typeof(AbpFeatureManagementApplicationContractsModule),
        typeof(AbpIdentityApplicationContractsModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(AbpTenantManagementApplicationContractsModule),
        typeof(AbpObjectExtendingModule),

        typeof(PrivateMessagingDomainSharedModule),
        typeof(PrivateMessagingApplicationContractsModule)
    )]
    public class BookStoreThemeApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            BookStoreThemeDtoExtensions.Configure();
        }
    }
}
