using DotNetCore.CAP;
using EasyAbp.Abp.EventBus.Cap;
using EasyAbp.PrivateMessaging;
using EasyAbp.PrivateMessaging.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Acme.BookStoreTheme.EntityFrameworkCore
{
    [DependsOn(
        typeof(BookStoreThemeDomainModule),
        typeof(AbpIdentityEntityFrameworkCoreModule),
        typeof(AbpIdentityServerEntityFrameworkCoreModule),
        typeof(AbpPermissionManagementEntityFrameworkCoreModule),
        typeof(AbpSettingManagementEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule),
        typeof(AbpBackgroundJobsEntityFrameworkCoreModule),
        typeof(AbpAuditLoggingEntityFrameworkCoreModule),
        typeof(AbpTenantManagementEntityFrameworkCoreModule),
        typeof(AbpFeatureManagementEntityFrameworkCoreModule),

        typeof(PrivateMessagingDomainModule),
        typeof(PrivateMessagingEntityFrameworkCoreModule),

        typeof(AbpEventBusCapModule)



        )]
    public class BookStoreThemeEntityFrameworkCoreModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            BookStoreThemeEfCoreEntityExtensionMappings.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BookStoreThemeDbContext>(options =>
            {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                /* The main point to change your DBMS.
                 * See also BookStoreThemeMigrationsDbContextFactory for EF Core tooling. */
                options.UseSqlServer();
            });
          
            var configuration = context.Services.GetConfiguration();

            //Configure<AbpRabbitMqEventBusOptions>(configuration.GetSection("RabbitMQ:EventBus"));

            //Configure<RabbitMQOptions>(configuration.GetSection("CAP:RabbitMQ"));

            context.AddCapEventBus(capOptions =>
            {
                capOptions.UseEntityFramework<BookStoreThemeDbContext>();
                capOptions.UseRabbitMQ(o => {
                    o.HostName = configuration.GetSection("CAP:RabbitMQ:HostName")?.Value;//UseRabbitMQ 服务器地址配置，支持配置IP地址和密码
                    o.ConnectionFactoryOptions = opt => {                        
                        //configuration.GetSection("CAP:RabbitMQ:ConnectionFactoryOptions");
                        //rabbitmq client ConnectionFactory config
                    };
                });               
                capOptions.UseDashboard();//CAP2.X版本以后官方提供了Dashboard页面访问。
            });

        }
    }
}
