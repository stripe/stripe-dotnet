// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardNetworkToken : StripeEntity<ChargePaymentMethodDetailsCardNetworkToken>
    {
        /// <summary>
        /// Indicates if Stripe used a network token, either user provided or Stripe managed when
        /// processing the transaction.
        /// </summary>
        [JsonProperty("used")]
        public bool Used { get; set; }
    }
}
