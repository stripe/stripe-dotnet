// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordPaymentMethodDetailsAuBecsDebit : StripeEntity<PaymentRecordPaymentMethodDetailsAuBecsDebit>
    {
        /// <summary>
        /// Bank-State-Branch number of the bank account.
        /// </summary>
        [JsonProperty("bsb_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bsb_number")]
#endif
        public string BsbNumber { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four digits of the bank account number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// ID of the mandate used to make this payment.
        /// </summary>
        [JsonProperty("mandate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate")]
#endif
        public string Mandate { get; set; }
    }
}
