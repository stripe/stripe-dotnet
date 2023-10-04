// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardExtendedAuthorization : StripeEntity<ChargePaymentMethodDetailsCardExtendedAuthorization>
    {
        /// <summary>
        /// Indicates whether or not the capture window is extended beyond the standard
        /// authorization.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
