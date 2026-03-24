// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ChargePaymentMethodDetailsCardNetworkToken : StripeEntity<ChargePaymentMethodDetailsCardNetworkToken>
    {
        /// <summary>
        /// Indicates if Stripe used a network token, either user provided or Stripe managed when
        /// processing the transaction.
        /// </summary>
        [JsonProperty("used")]
        [STJS.JsonPropertyName("used")]
        public bool Used { get; set; }
    }
}
