// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceBancontact : StripeEntity<SourceBancontact>
    {
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif

        public string BankCode { get; set; }

        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif

        public string BankName { get; set; }

        [JsonProperty("bic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bic")]
#endif

        public string Bic { get; set; }

        [JsonProperty("iban_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iban_last4")]
#endif

        public string IbanLast4 { get; set; }

        [JsonProperty("preferred_language")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preferred_language")]
#endif

        public string PreferredLanguage { get; set; }

        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif

        public string StatementDescriptor { get; set; }
    }
}
