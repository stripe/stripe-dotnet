using Newtonsoft.Json;

namespace Stripe
{
    public class StripeCardListOptions : StripeListOptions
    {
        [JsonProperty("object")]
        internal string Object => "card";
    }
}
