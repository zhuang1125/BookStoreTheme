using System.Threading.Tasks;

namespace Acme.BookStoreTheme.Data
{
    public interface IBookStoreThemeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
