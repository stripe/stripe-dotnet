// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsAmazonPay : StripeEntity<PaymentRecordPaymentMethodDetailsAmazonPay>
    {
        [JsonProperty("funding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding")]
#endif
        public PaymentRecordPaymentMethodDetailsAmazonPayFunding Funding { get; set; }
    }
}
