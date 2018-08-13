using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using MyTrips.Resources;
using System.Reflection;

namespace MyTrips.Utilities
{
    public static class MvcOptionsExtension
    {
        /// <summary>
        /// localize ModelBinding messages, e.g. when user enters string value instead of number...
        /// these messages can't be localized like data attributes
        /// </summary>
        /// <param name="mvc"></param>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IMvcBuilder AddModelBindingMessagesLocalizer
            (this IMvcBuilder mvc, IServiceCollection services)
        {
            return mvc.AddMvcOptions(o =>
            {
                var type = typeof(MyDataAnnotations);
                var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
                var factory = services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
                var localizer = factory.Create("MyDataAnnotations", assemblyName.Name);

                o.ModelBindingMessageProvider
                    .SetAttemptedValueIsInvalidAccessor((x, y) => localizer["InvalidValue"]);

                o.ModelBindingMessageProvider
                    .SetValueMustBeANumberAccessor((x) => localizer["MustBeNumber"]);
            });
        }
    }
}
