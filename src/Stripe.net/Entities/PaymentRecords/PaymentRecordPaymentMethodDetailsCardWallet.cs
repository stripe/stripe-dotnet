// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsCardWallet : StripeEntity<PaymentRecordPaymentMethodDetailsCardWallet>
    {
        [JsonProperty("apple_pay")]
        [STJS.JsonPropertyName("apple_pay")]
        public PaymentRecordPaymentMethodDetailsCardWalletApplePay ApplePay { get; set; }

        /// <summary>
        /// (For tokenized numbers only.) The last four digits of the device account number.
        /// </summary>
        [JsonProperty("dynamic_last4")]
        [STJS.JsonPropertyName("dynamic_last4")]
        public string DynamicLast4 { get; set; }

        [JsonProperty("google_pay")]
        [STJS.JsonPropertyName("google_pay")]
        public PaymentRecordPaymentMethodDetailsCardWalletGooglePay GooglePay { get; set; }

        /// <summary>
        /// The type of the card wallet, one of <c>apple_pay</c> or <c>google_pay</c>. An additional
        /// hash is included on the Wallet subhash with a name matching this value. It contains
        /// additional information specific to the card wallet type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
