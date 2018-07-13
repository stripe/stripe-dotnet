namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeCardListOptions : StripeListOptions
    {
        [JsonProperty("object")]
        internal string Object => "card";
    }
}
