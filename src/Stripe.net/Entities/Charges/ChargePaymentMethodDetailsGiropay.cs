// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentMethodDetailsGiropay : StripeEntity<ChargePaymentMethodDetailsGiropay>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif

        public string BankCode { get; set; }

        /// <summary>
        /// Name of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif

        public string BankName { get; set; }

        /// <summary>
        /// Bank Identifier Code of the bank associated with the bank account.
        /// </summary>
        [JsonProperty("bic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bic")]
#endif

        public string Bic { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by Giropay directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// Giropay rarely provides this information so the attribute is usually empty.
        /// </summary>
        [JsonProperty("verified_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_name")]
#endif

        public string VerifiedName { get; set; }
    }
}
