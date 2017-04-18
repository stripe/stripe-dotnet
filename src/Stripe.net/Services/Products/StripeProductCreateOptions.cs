using Newtonsoft.Json;

namespace Stripe
{
    public class StripeProductCreateOptions : StripeProductSharedOptions
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
