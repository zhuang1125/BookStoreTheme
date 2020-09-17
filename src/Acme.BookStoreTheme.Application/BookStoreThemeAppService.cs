using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStoreTheme.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStoreTheme
{
    /* Inherit your application services from this class.
     */
    public abstract class BookStoreThemeAppService : ApplicationService
    {
        protected BookStoreThemeAppService()
        {
            LocalizationResource = typeof(BookStoreThemeResource);
        }
    }
}
