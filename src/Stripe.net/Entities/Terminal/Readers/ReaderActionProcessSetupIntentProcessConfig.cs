// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionProcessSetupIntentProcessConfig : StripeEntity<ReaderActionProcessSetupIntentProcessConfig>
    {
        /// <summary>
        /// Enable customer initiated cancellation when processing this SetupIntent.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enable_customer_cancellation")]
#endif

        public bool EnableCustomerCancellation { get; set; }
    }
}
