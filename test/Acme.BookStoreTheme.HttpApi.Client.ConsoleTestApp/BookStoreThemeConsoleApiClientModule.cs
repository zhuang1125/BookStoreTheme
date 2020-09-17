using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Acme.BookStoreTheme.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(BookStoreThemeHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BookStoreThemeConsoleApiClientModule : AbpModule
    {
        
    }
}
