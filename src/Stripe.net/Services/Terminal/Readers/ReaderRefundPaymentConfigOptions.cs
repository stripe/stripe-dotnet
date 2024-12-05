// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderRefundPaymentConfigOptions : INestedOptions
    {
        /// <summary>
        /// Enables cancel button on transaction screens.
        /// </summary>
        [JsonProperty("enable_customer_cancellation")]
        public bool? EnableCustomerCancellation { get; set; }
    }
}
