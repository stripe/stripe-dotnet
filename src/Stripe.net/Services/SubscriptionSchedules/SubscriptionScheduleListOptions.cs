// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleListOptions : ListOptions
    {
        /// <summary>
        /// Only return subscription schedules that were created canceled the given date interval.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CanceledAt { get; set; }

        /// <summary>
        /// Only return subscription schedules that completed during the given date interval.
        /// </summary>
        [JsonProperty("completed_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("completed_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CompletedAt { get; set; }

        /// <summary>
        /// Only return subscription schedules that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return subscription schedules for the given customer.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return subscription schedules for the given account.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// Only return subscription schedules that were released during the given date interval.
        /// </summary>
        [JsonProperty("released_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("released_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> ReleasedAt { get; set; }

        /// <summary>
        /// Only return subscription schedules that have not started yet.
        /// </summary>
        [JsonProperty("scheduled")]
        [STJS.JsonPropertyName("scheduled")]
        public bool? Scheduled { get; set; }
    }
}
