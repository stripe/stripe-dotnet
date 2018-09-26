namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class OrderStatusTransitionsOptions : INestedOptions
    {
        [JsonProperty("canceled")]
        public DateTime? Canceled { get; set; }

        [JsonProperty("canceled")]
        public DateRangeOptions CanceledRange { get; set; }

        [JsonProperty("fulfilled")]
        public DateTime? Fulfilled { get; set; }

        [JsonProperty("fulfilled")]
        public DateRangeOptions FulfilledRange { get; set; }

        [JsonProperty("paid")]
        public DateTime? Paid { get; set; }

        [JsonProperty("paid")]
        public DateRangeOptions PaidRange { get; set; }

        [JsonProperty("returned")]
        public DateTime? Returned { get; set; }

        [JsonProperty("returned")]
        public DateRangeOptions ReturnedRange { get; set; }
    }
}
