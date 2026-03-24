// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsCardWalletApplePay : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCardWalletApplePay>
    {
        /// <summary>
        /// Type of the apple_pay transaction, one of <c>apple_pay</c> or <c>apple_pay_later</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
