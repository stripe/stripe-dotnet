namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeSourceListOptions : INestedOptions
    {
        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
