// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsSwish : StripeEntity<ChargePaymentMethodDetailsSwish>
    {
        /// <summary>
        /// Uniquely identifies the payer's Swish account. You can use this attribute to check
        /// whether two Swish transactions were paid for by the same payer.
        /// </summary>
        [JsonProperty("fingerprint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fingerprint")]
#endif

        public string Fingerprint { get; set; }

        /// <summary>
        /// Payer bank reference number for the payment.
        /// </summary>
        [JsonProperty("payment_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_reference")]
#endif

        public string PaymentReference { get; set; }

        /// <summary>
        /// The last four digits of the Swish account phone number.
        /// </summary>
        [JsonProperty("verified_phone_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_phone_last4")]
#endif

        public string VerifiedPhoneLast4 { get; set; }
    }
}
