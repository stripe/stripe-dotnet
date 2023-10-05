// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardMulticapture : StripeEntity<ChargePaymentMethodDetailsCardMulticapture>
    {
        /// <summary>
        /// Indicates whether or not multiple captures are supported.
        /// One of: <c>available</c>, or <c>unavailable</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
