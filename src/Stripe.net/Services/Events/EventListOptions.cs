// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

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
