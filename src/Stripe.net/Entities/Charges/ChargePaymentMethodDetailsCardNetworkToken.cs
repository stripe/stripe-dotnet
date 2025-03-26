// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsCardNetworkToken : StripeEntity<ChargePaymentMethodDetailsCardNetworkToken>
    {
        /// <summary>
        /// Indicates if Stripe used a network token, either user provided or Stripe managed when
        /// processing the transaction.
        /// </summary>
        [JsonProperty("used")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("used")]
#endif
        public bool Used { get; set; }
    }
}
