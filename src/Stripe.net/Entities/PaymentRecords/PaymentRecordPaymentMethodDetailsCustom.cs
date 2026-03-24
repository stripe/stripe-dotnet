// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsCustom : StripeEntity<PaymentRecordPaymentMethodDetailsCustom>
    {
        /// <summary>
        /// Display name for the custom (user-defined) payment method type used to make this
        /// payment.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The custom payment method type associated with this payment.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
