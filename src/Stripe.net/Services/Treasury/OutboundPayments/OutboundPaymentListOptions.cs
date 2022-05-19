// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
