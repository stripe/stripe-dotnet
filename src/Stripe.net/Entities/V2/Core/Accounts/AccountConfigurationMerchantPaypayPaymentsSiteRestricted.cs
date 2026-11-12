// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchantPaypayPaymentsSiteRestricted : StripeEntity<AccountConfigurationMerchantPaypayPaymentsSiteRestricted>
    {
        /// <summary>
        /// The file explaining the payment flow for the business.
        /// </summary>
        [JsonProperty("payment_flow_file")]
        [STJS.JsonPropertyName("payment_flow_file")]
        public string PaymentFlowFile { get; set; }
    }
}
