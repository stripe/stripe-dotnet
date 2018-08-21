namespace Stripe
{
    using Newtonsoft.Json;

    public class EventListOptions : ListOptions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created")]
        public DateFilter Created { get; set; }
    }
}