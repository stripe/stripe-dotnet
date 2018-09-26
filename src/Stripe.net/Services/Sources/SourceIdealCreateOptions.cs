namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceIdealCreateOptions : INestedOptions
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
