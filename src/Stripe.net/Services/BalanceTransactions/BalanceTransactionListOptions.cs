// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class BalanceTransactionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payout")]
        public string Payout { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
