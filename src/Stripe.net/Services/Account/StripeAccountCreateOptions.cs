using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountCreateOptions : StripeAccountSharedOptions
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
