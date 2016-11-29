using Newtonsoft.Json;

namespace Stripe
{
    public class StripeRecipientListOptions : StripeListOptions
    {
        [JsonProperty("verified")]
        public bool? Verified { get; set; }
    }
}