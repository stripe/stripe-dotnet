// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedCreditListOptions : ListOptions
    {
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonProperty("linked_flows")]
        public ReceivedCreditLinkedFlowsOptions LinkedFlows { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
