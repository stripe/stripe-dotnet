// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderCollectPaymentMethodOptions : BaseOptions
    {
        /// <summary>
        /// Configuration overrides for this collection, such as tipping, surcharging, and customer
        /// cancellation settings.
        /// </summary>
        [JsonProperty("collect_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collect_config")]
#endif
        public ReaderCollectConfigOptions CollectConfig { get; set; }

        /// <summary>
        /// The ID of the PaymentIntent to collect a payment method for.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }
    }
}
