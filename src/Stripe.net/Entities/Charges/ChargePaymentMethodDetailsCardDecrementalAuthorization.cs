// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardDecrementalAuthorization : StripeEntity<ChargePaymentMethodDetailsCardDecrementalAuthorization>
    {
        /// <summary>
        /// Indicates whether or not the decremental authorization feature is supported.
        /// One of: <c>available</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
