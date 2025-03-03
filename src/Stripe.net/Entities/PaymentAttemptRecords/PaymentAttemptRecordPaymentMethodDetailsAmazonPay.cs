// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsAmazonPay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsAmazonPay>
    {
        [JsonProperty("funding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("funding")]
#endif
        public PaymentAttemptRecordPaymentMethodDetailsAmazonPayFunding Funding { get; set; }
    }
}
