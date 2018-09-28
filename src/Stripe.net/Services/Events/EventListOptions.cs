namespace Stripe
{
    using Newtonsoft.Json;

    public class EventListOptions : ListOptionsWithCreated
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}