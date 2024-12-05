// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionProcessSetupIntentProcessConfig : StripeEntity<ReaderActionProcessSetupIntentProcessConfig>
    {
        /// <summary>
        /// Enable customer initiated cancellation when processing this SetupIntent.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
        public bool EnableCustomerCancellation { get; set; }
    }
}
