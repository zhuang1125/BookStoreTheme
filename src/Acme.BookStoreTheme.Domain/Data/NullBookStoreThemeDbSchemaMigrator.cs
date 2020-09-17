using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreTheme.Data
{
    /* This is used if database provider does't define
     * IBookStoreThemeDbSchemaMigrator implementation.
     */
    public class NullBookStoreThemeDbSchemaMigrator : IBookStoreThemeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}