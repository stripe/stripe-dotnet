// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceIdeal : StripeEntity<SourceIdeal>
    {
        [JsonProperty("bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank")]
#endif

        public string Bank { get; set; }

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

        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif

        public string StatementDescriptor { get; set; }
    }
}
