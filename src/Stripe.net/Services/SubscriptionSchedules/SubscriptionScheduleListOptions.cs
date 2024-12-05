// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return subscription schedules that were created canceled the given date interval.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CanceledAt { get; set; }

        /// <summary>
        /// Only return subscription schedules that completed during the given date interval.
        /// </summary>
        [JsonProperty("completed_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CompletedAt { get; set; }

        /// <summary>
        /// Only return subscription schedules for the given customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return subscription schedules that were released during the given date interval.
        /// </summary>
        [JsonProperty("released_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> ReleasedAt { get; set; }

        /// <summary>
        /// Only return subscription schedules that have not started yet.
        /// </summary>
        [JsonProperty("scheduled")]
        public bool? Scheduled { get; set; }
    }
}
