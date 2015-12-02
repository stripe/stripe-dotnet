using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountListOptions : StripeListOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("managed")]
        public bool Managed { get; set; }
    }
}