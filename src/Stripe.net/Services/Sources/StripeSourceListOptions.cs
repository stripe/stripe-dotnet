namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeSourceListOptions : StripeListOptions
    {
        [JsonProperty("object")]
        internal string Object => "source";

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
