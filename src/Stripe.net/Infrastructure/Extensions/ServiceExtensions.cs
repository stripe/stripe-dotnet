namespace Stripe.Infrastructure.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;

    internal static class ServiceExtensions
    {
        /// <summary>
        /// Returns the list of attributes to expand in requests sent by the service.
        /// </summary>
        /// <typeparam name="T">Entity type returned by the service.</typeparam>
        /// <param name="service">The service sending the requests.</param>
        /// <param name="isListMethod">Whether the request is a list request or not.</param>
        /// <returns>The list of attributes to expand.</returns>
        public static List<string> Expansions<T>(this Service<T> service, bool isListMethod)
            where T : IStripeEntity
        {
            return service.GetType()
                .GetRuntimeProperties()
                .Where(p => p.Name.StartsWith("Expand") && p.PropertyType == typeof(bool))
                .Where(p => (bool)p.GetValue(service, null))
                .Select(p => StringUtils.ToSnakeCase(p.Name.Substring("Expand".Length)))
                .Select(i => isListMethod ? $"data.{i}" : i)
                .ToList();
        }
    }
}
