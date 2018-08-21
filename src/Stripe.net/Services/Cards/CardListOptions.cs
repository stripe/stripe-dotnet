namespace Stripe
{
    using Newtonsoft.Json;

    public class CardListOptions : ListOptions
    {
        [JsonProperty("object")]
        internal string Object => "card";
    }
}
