// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodPaypal : StripeEntity<PaymentMethodPaypal>
    {
        /// <summary>
        /// Owner's email. Values are provided by PayPal directly (if supported) at the time of
        /// authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("payer_email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer_email")]
#endif

        public string PayerEmail { get; set; }

        /// <summary>
        /// PayPal account PayerID. This identifier uniquely identifies the PayPal customer.
        /// </summary>
        [JsonProperty("payer_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer_id")]
#endif

        public string PayerId { get; set; }
    }
}
