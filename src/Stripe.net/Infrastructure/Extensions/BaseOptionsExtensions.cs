namespace Stripe.Infrastructure.Extensions
{
    using System.Net.Http;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;

    internal static class BaseOptionsExtensions
    {
        /// <summary>Serializes the parameters as a query string.</summary>
        /// <param name="options">The options class containing the parameters.</param>
        /// <returns>A form-encoded string represensation of the parameters.</returns>
        public static string ToQueryString(this BaseOptions options)
        {
            return FormEncoder.CreateQueryString(options);
        }
    }
}
