using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSourceListOptions : StripeListOptions
    {
        [JsonProperty("object")]
        internal string Object => "source";

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
