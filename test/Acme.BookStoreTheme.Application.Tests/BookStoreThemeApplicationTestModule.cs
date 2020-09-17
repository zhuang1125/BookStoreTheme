using Volo.Abp.Modularity;

namespace Acme.BookStoreTheme
{
    [DependsOn(
        typeof(BookStoreThemeApplicationModule),
        typeof(BookStoreThemeDomainTestModule)
        )]
    public class BookStoreThemeApplicationTestModule : AbpModule
    {

    }
}