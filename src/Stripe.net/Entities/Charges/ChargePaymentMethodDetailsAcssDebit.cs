// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsAcssDebit : StripeEntity<ChargePaymentMethodDetailsAcssDebit>
    {
        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

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
        /// Institution number of the bank account.
        /// </summary>
        [JsonProperty("institution_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("institution_number")]
#endif
        public string InstitutionNumber { get; set; }

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

        /// <summary>
        /// Transit number of the bank account.
        /// </summary>
        [JsonProperty("transit_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transit_number")]
#endif
        public string TransitNumber { get; set; }
    }
}
