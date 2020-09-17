using Acme.BookStoreTheme.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.BookStoreTheme.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BookStoreThemeEntityFrameworkCoreDbMigrationsModule),
        typeof(BookStoreThemeApplicationContractsModule)
        )]
    public class BookStoreThemeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
