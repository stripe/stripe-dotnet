// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentAttemptRecordPaymentMethodDetailsCardWalletApplePay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCardWalletApplePay>
    {
        /// <summary>
        /// Type of the apple_pay transaction, one of <c>apple_pay</c> or <c>apple_pay_later</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
