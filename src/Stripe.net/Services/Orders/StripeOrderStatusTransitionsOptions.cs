namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeOrderStatusTransitionsOptions : INestedOptions
    {
        [JsonProperty("status_transitions[canceled]")]
        public StripeDateFilter Canceled { get; set; }

        [JsonProperty("status_transitions[fulfilled]")]
        public StripeDateFilter Fulfilled { get; set; }

        [JsonProperty("status_transitions[paid]")]
        public StripeDateFilter Paid { get; set; }

        [JsonProperty("status_transitions[returned]")]
        public StripeDateFilter Returned { get; set; }
    }
}
