// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodPaypal : StripeEntity<PaymentMethodPaypal>
    {
        /// <summary>
        /// Two-letter ISO code representing the buyer's country. Values are provided by PayPal
        /// directly (if supported) at the time of authorization or settlement. They cannot be set
        /// or mutated.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Owner's email. Values are provided by PayPal directly (if supported) at the time of
        /// authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("payer_email")]
        [STJS.JsonPropertyName("payer_email")]
        public string PayerEmail { get; set; }

        /// <summary>
        /// PayPal account PayerID. This identifier uniquely identifies the PayPal customer.
        /// </summary>
        [JsonProperty("payer_id")]
        [STJS.JsonPropertyName("payer_id")]
        public string PayerId { get; set; }
    }
}
