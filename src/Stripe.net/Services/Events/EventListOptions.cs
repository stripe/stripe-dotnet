namespace Stripe
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class EventListOptions : ListOptionsWithCreated
    {
        [JsonProperty("delivery_success")]
        public bool? DeliverySuccess { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("types")]
        public List<string> Types { get; set; }
    }
}
