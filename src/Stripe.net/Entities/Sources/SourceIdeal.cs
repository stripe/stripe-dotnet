// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceIdeal : StripeEntity<SourceIdeal>
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("iban_last4")]
        public string IbanLast4 { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
