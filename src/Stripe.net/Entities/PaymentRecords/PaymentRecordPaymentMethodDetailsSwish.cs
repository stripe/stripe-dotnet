// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsSwish : StripeEntity<PaymentRecordPaymentMethodDetailsSwish>
    {
        /// <summary>
        /// Uniquely identifies the payer's Swish account. You can use this attribute to check
        /// whether two Swish transactions were paid for by the same payer.
        /// </summary>
        [JsonProperty("fingerprint")]
        [STJS.JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/terminal/locations">location</a> that
        /// this transaction's reader is assigned to.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Payer bank reference number for the payment.
        /// </summary>
        [JsonProperty("payment_reference")]
        [STJS.JsonPropertyName("payment_reference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// ID of the <a href="https://docs.stripe.com/api/terminal/readers">reader</a> this
        /// transaction was made on.
        /// </summary>
        [JsonProperty("reader")]
        [STJS.JsonPropertyName("reader")]
        public string Reader { get; set; }

        /// <summary>
        /// The last four digits of the Swish account phone number.
        /// </summary>
        [JsonProperty("verified_phone_last4")]
        [STJS.JsonPropertyName("verified_phone_last4")]
        public string VerifiedPhoneLast4 { get; set; }
    }
}
