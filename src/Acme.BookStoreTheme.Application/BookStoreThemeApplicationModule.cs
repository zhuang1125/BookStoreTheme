using EasyAbp.PrivateMessaging;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace Acme.BookStoreTheme
{
    [DependsOn(
        typeof(BookStoreThemeDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(BookStoreThemeApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),

        typeof(PrivateMessagingDomainModule),
        typeof(PrivateMessagingApplicationModule)

        )]
    public class BookStoreThemeApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BookStoreThemeApplicationModule>();
            });
        }
    }
}
