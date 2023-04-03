// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;

    public class FinancingTransactionListOptions : ListOptions
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }

        [JsonProperty("financing_offer")]
        public string FinancingOffer { get; set; }

        [JsonProperty("reversed_transaction")]
        public string ReversedTransaction { get; set; }

        [JsonProperty("treasury_transaction")]
        public string TreasuryTransaction { get; set; }
    }
}
