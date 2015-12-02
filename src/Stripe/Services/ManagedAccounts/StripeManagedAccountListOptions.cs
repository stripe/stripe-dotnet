using Newtonsoft.Json;

namespace Stripe
{
    public class StripeManagedAccountListOptions : StripeListOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }
    }
}