// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodDataAcssDebitOptions : INestedOptions
    {
        /// <summary>
        /// Customer's bank account number.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif

        public string AccountNumber { get; set; }

        /// <summary>
        /// Institution number of the customer's bank.
        /// </summary>
        [JsonProperty("institution_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("institution_number")]
#endif

        public string InstitutionNumber { get; set; }

        /// <summary>
        /// Transit number of the customer's bank.
        /// </summary>
        [JsonProperty("transit_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transit_number")]
#endif

        public string TransitNumber { get; set; }
    }
}
