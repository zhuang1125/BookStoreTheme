using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.BookStoreTheme.EntityFrameworkCore
{
    [DependsOn(
        typeof(BookStoreThemeEntityFrameworkCoreModule)
        )]
    public class BookStoreThemeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BookStoreThemeMigrationsDbContext>();
        }
    }
}
