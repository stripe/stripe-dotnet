// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TaxFundSourceTaxFundAccount : StripeEntity<TaxFundSourceTaxFundAccount>
    {
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
