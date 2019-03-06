namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SubscriptionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// The billing mode of the subscriptions to retrieve. One of <see cref="Billing" />.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        /// <summary>
        /// A filter on the list based on the object current_period_end field.
        /// </summary>
        [JsonProperty("current_period_end")]
        public DateTime? CurrentPeriodEnd { get; set; }

        /// <summary>
        /// A filter on the list based on the object current_period_end field.
        /// </summary>
        [JsonProperty("current_period_end")]
        public DateRangeOptions CurrentPeriodEndRange { get; set; }

        /// <summary>
        /// A filter on the list based on the object current_period_start field.
        /// </summary>
        [JsonProperty("current_period_start")]
        public DateTime? CurrentPeriodStart { get; set; }

        /// <summary>
        /// A filter on the list based on the object current_period_start field.
        /// </summary>
        [JsonProperty("current_period_start")]
        public DateRangeOptions CurrentPeriodStartRange { get; set; }

        /// <summary>
        /// The ID of the customer whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// The ID of the plan whose subscriptions will be retrieved.
        /// </summary>
        [JsonProperty("plan")]
        public string PlanId { get; set; }

        /// <summary>
        /// The status of the subscriptions to retrieve. One of <see cref="SubscriptionStatuses"/> or <c>all</c>. Passing in a value of <c>canceled</c> will return all canceled subscriptions, including those belonging to deleted customers. Passing in a value of <c>all</c> will return subscriptions of all statuses.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
