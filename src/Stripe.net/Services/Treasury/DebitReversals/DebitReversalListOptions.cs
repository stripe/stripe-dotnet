// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class DebitReversalListOptions : ListOptions
    {
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonProperty("received_debit")]
        public string ReceivedDebit { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
