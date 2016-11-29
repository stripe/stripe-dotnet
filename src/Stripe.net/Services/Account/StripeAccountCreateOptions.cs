using Newtonsoft.Json;

namespace Stripe
{
    public class StripeAccountCreateOptions : StripeAccountSharedOptions
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("managed")]
        public bool? Managed { get; set; }
    }
}
