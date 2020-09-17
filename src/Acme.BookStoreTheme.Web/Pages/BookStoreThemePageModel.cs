using Acme.BookStoreTheme.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookStoreTheme.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BookStoreThemePageModel : AbpPageModel
    {
        protected BookStoreThemePageModel()
        {
            LocalizationResourceType = typeof(BookStoreThemeResource);
        }
    }
}