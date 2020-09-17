using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookStoreTheme.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreTheme.EntityFrameworkCore
{
    public class EntityFrameworkCoreBookStoreThemeDbSchemaMigrator
        : IBookStoreThemeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBookStoreThemeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BookStoreThemeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BookStoreThemeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}