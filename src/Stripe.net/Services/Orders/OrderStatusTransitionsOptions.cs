namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderStatusTransitionsOptions : INestedOptions
    {
        [JsonProperty("canceled")]
        public DateFilter Canceled { get; set; }

        [JsonProperty("fulfilled")]
        public DateFilter Fulfilled { get; set; }

        [JsonProperty("paid")]
        public DateFilter Paid { get; set; }

        [JsonProperty("returned")]
        public DateFilter Returned { get; set; }
    }
}
