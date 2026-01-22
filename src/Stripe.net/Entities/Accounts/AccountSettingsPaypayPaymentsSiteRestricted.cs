// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPaypayPaymentsSiteRestricted : StripeEntity<AccountSettingsPaypayPaymentsSiteRestricted>
    {
        /// <summary>
        /// File explaining the payment flow for your business.
        /// </summary>
        [JsonProperty("payment_flow_file")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_flow_file")]
#endif
        public string PaymentFlowFile { get; set; }
    }
}
