using Acme.BookStoreTheme.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStoreTheme.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BookStoreThemeController : AbpController
    {
        protected BookStoreThemeController()
        {
            LocalizationResource = typeof(BookStoreThemeResource);
        }
    }
}