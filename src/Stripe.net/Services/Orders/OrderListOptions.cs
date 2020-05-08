namespace Stripe
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class OrderListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("ids")]
        public List<string> Ids { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
        public StatusTransitionsOptions StatusTransitions { get; set; }

        [JsonProperty("upstream_ids")]
        public List<string> UpstreamIds { get; set; }
    }
}
