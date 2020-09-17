using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Acme.BookStoreTheme.EntityFrameworkCore
{
    public static class BookStoreThemeDbContextModelCreatingExtensions
    {
        public static void ConfigureBookStoreTheme(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BookStoreThemeConsts.DbTablePrefix + "YourEntities", BookStoreThemeConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}