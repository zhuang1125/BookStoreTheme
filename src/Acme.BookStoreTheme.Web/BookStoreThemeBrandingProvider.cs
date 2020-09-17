using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreTheme.Web
{
    [Dependency(ReplaceServices = true)]
    public class BookStoreThemeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "BookStoreTheme";
    }
}
