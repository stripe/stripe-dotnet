using Newtonsoft.Json;

namespace Stripe
{
    public class StripeShipping : StripeEntity
    {
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}