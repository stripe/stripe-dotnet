// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionEnrichments : StripeEntity<TransactionEnrichments>
    {
        [JsonProperty("merchant")]
        [STJS.JsonPropertyName("merchant")]
        public TransactionEnrichmentsMerchant Merchant { get; set; }
    }
}
