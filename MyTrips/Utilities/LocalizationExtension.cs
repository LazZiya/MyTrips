using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace MyTrips.Utilities
{
    public static class LocalizationExtension
    {
        public static void ConfigureRequestLocalization(this IServiceCollection services)
        {
            var cultures = new CultureInfo[]
            {
                new CultureInfo("en"),
                new CultureInfo("tr"),
                new CultureInfo("ar") {
                    // Arabic cultures uses Hijri calendar by default
                    // comment the below line to use Hijri calendar instead of Gregorian
                    DateTimeFormat = { Calendar = new GregorianCalendar() }
                }
            };

            services.Configure<RequestLocalizationOptions>(ops =>
            {
                ops.DefaultRequestCulture = new RequestCulture("en");
                ops.SupportedCultures = cultures;
                ops.SupportedUICultures = cultures;

                // add RouteValueRequestCultureProvider to the beginning of the providers list. 
                ops.RequestCultureProviders.Insert(0, new RouteValueRequestCultureProvider(cultures));
            });
        }
    }
}