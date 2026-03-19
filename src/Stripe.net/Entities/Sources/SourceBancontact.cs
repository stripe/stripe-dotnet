// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceBancontact : StripeEntity<SourceBancontact>
    {
        [JsonProperty("bank_code")]
        [STJS.JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bic")]
        [STJS.JsonPropertyName("bic")]
        public string Bic { get; set; }

        [JsonProperty("iban_last4")]
        [STJS.JsonPropertyName("iban_last4")]
        public string IbanLast4 { get; set; }

        [JsonProperty("preferred_language")]
        [STJS.JsonPropertyName("preferred_language")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
