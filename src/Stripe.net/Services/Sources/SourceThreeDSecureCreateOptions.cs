namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceThreeDSecureCreateOptions : INestedOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }
    }
}
