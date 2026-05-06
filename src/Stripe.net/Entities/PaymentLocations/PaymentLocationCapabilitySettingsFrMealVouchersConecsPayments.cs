// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLocationCapabilitySettingsFrMealVouchersConecsPayments : StripeEntity<PaymentLocationCapabilitySettingsFrMealVouchersConecsPayments>
    {
        /// <summary>
        /// Supported meal voucher issuers.
        /// </summary>
        [JsonProperty("supported_issuers")]
        [STJS.JsonPropertyName("supported_issuers")]
        public PaymentLocationCapabilitySettingsFrMealVouchersConecsPaymentsSupportedIssuers SupportedIssuers { get; set; }
    }
}
