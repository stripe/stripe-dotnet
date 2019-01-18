namespace Stripe.Infrastructure.Extensions
{
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;

    internal static class BaseOptionsExtensions
    {
        /// <summary>Serializes the parameters with form encoding.</summary>
        /// <param name="options">The options class containing the parameters.</param>
        /// <param name="includeExtraParams">Whether to include extra parameters in the query string or not.</param>
        /// <param name="includeExpandParams">Whether to include expand parameters in the query string or not.</param>
        /// <returns>A form-encoded string represensation of the parameters.</returns>
        public static string ToQueryString(this BaseOptions options, bool includeExtraParams = true, bool includeExpandParams = true)
        {
            return FormEncoder.JoinQueries(
                FormEncoder.EncodeOptions(options),
                includeExtraParams ? FormEncoder.EncodeDictionary(options.ExtraParams) : null,
                includeExpandParams ? FormEncoder.EncodeList(options.Expand, "expand") : null);
        }
    }
}
