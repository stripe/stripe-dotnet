// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReaderCollectPaymentMethodOptions : BaseOptions
    {
        /// <summary>
        /// Configuration overrides for this collection, such as tipping, surcharging, and customer
        /// cancellation settings.
        /// </summary>
        [JsonProperty("collect_config")]
        [STJS.JsonPropertyName("collect_config")]
        public ReaderCollectConfigOptions CollectConfig { get; set; }

        /// <summary>
        /// The ID of the PaymentIntent to collect a payment method for.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
