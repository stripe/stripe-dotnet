namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeOrderStatusTransitionsOptions : INestedOptions
    {
        [JsonProperty("canceled")]
        public StripeDateFilter Canceled { get; set; }

        [JsonProperty("fulfilled")]
        public StripeDateFilter Fulfilled { get; set; }

        [JsonProperty("paid")]
        public StripeDateFilter Paid { get; set; }

        [JsonProperty("returned")]
        public StripeDateFilter Returned { get; set; }
    }
}
