// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsStripeBalance : StripeEntity<ChargePaymentMethodDetailsStripeBalance>
    {
        /// <summary>
        /// The connected account ID whose Stripe balance to use as the source of payment.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }
    }
}
