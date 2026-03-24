// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceIdeal : StripeEntity<SourceIdeal>
    {
        [JsonProperty("bank")]
        [STJS.JsonPropertyName("bank")]
        public string Bank { get; set; }

        [JsonProperty("bic")]
        [STJS.JsonPropertyName("bic")]
        public string Bic { get; set; }

        [JsonProperty("iban_last4")]
        [STJS.JsonPropertyName("iban_last4")]
        public string IbanLast4 { get; set; }

        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
