// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using Newtonsoft.Json;

    public class FinancingOfferListOptions : ListOptionsWithCreated
    {
        [JsonProperty("connected_account")]
        public string ConnectedAccount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
