// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountEnrichmentState : StripeEntity<AccountEnrichmentState>
    {
        /// <summary>
        /// The enrichment status for merchant name normalization.
        /// </summary>
        [JsonProperty("merchant")]
        [STJS.JsonPropertyName("merchant")]
        public AccountEnrichmentStateMerchant Merchant { get; set; }
    }
}
