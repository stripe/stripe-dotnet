namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardListOptions : ListOptions
    {
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        internal string Object => "card";
    }
}
