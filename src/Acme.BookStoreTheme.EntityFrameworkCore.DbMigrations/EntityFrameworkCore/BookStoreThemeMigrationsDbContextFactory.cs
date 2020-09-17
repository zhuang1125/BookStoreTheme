using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStoreTheme.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class BookStoreThemeMigrationsDbContextFactory : IDesignTimeDbContextFactory<BookStoreThemeMigrationsDbContext>
    {
        public BookStoreThemeMigrationsDbContext CreateDbContext(string[] args)
        {
            BookStoreThemeEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BookStoreThemeMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BookStoreThemeMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.BookStoreTheme.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
