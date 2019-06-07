namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A filter on the list based on the object <c>canceled_at</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CanceledAt { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>completed_at</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("completed_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CompletedAt { get; set; }

        /// <summary>
        /// Only return subscription schedules for the given customer.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>released_at</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
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
