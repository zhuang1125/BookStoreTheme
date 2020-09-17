using EasyAbp.PrivateMessaging;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace Acme.BookStoreTheme
{
    [DependsOn(
        typeof(BookStoreThemeApplicationContractsModule),
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpTenantManagementHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule),

        typeof(PrivateMessagingApplicationContractsModule),
        typeof(PrivateMessagingHttpApiClientModule)

    )]
    public class BookStoreThemeHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(BookStoreThemeApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
