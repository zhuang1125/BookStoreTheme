using Acme.BookStoreTheme.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStoreTheme
{
    [DependsOn(
        typeof(BookStoreThemeEntityFrameworkCoreTestModule)
        )]
    public class BookStoreThemeDomainTestModule : AbpModule
    {

    }
}