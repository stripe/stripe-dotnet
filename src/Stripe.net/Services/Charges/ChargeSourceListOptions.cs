namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeSourceListOptions : INestedOptions, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }
    }
}
