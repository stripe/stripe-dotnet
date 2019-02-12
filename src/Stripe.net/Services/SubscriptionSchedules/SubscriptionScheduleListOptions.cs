namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SubscriptionScheduleListOptions : ListOptionsWithCreated
    {
        [JsonProperty("canceled_at")]
        public DateTime? CanceledAt { get; set; }

        [JsonProperty("canceled_at")]
        public DateRangeOptions CanceledAtRange { get; set; }

        [JsonProperty("completed_at")]
        public DateTime? CompletedAt { get; set; }

        [JsonProperty("completed_at")]
        public DateRangeOptions CompletedAtRange { get; set; }

        /// <summary>
        /// Only return subscription schedules for the given customer.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("released_at")]
        public DateTime? ReleasedAt { get; set; }

        [JsonProperty("released_at")]
        public DateRangeOptions ReleasedAtRange { get; set; }

        /// <summary>
        /// Only return subscription schedules that have not started yet.
        /// </summary>
        [JsonProperty("scheduled")]
        public bool? Scheduled { get; set; }
    }
}
