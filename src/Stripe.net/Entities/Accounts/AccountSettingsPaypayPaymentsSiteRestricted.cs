// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSettingsPaypayPaymentsSiteRestricted : StripeEntity<AccountSettingsPaypayPaymentsSiteRestricted>
    {
        /// <summary>
        /// File explaining the payment flow for your business.
        /// </summary>
        [JsonProperty("payment_flow_file")]
        [STJS.JsonPropertyName("payment_flow_file")]
        public string PaymentFlowFile { get; set; }
    }
}
