// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceGiropay : StripeEntity<SourceGiropay>
    {
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
