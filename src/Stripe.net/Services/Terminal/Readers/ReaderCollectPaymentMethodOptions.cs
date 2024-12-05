// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderCollectPaymentMethodOptions : BaseOptions
    {
        /// <summary>
        /// Configuration overrides.
        /// </summary>
        [JsonProperty("collect_config")]
        public ReaderCollectConfigOptions CollectConfig { get; set; }

        /// <summary>
        /// PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
