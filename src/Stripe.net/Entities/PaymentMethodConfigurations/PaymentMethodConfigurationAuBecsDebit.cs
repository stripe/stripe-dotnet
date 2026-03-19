// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodConfigurationAuBecsDebit : StripeEntity<PaymentMethodConfigurationAuBecsDebit>
    {
        /// <summary>
        /// Whether this payment method may be offered at checkout. True if
        /// <c>display_preference</c> is <c>on</c> and the payment method's capability is active.
        /// </summary>
        [JsonProperty("available")]
        [STJS.JsonPropertyName("available")]
        public bool Available { get; set; }

        [JsonProperty("display_preference")]
        [STJS.JsonPropertyName("display_preference")]
        public PaymentMethodConfigurationAuBecsDebitDisplayPreference DisplayPreference { get; set; }
    }
}
