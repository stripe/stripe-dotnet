// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return subscription schedules that were created canceled the given date interval.
        /// </summary>
        [JsonProperty("canceled_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CanceledAt { get; set; }

        /// <summary>
        /// Only return subscription schedules that completed during the given date interval.
        /// </summary>
        [JsonProperty("completed_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("completed_at")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CompletedAt { get; set; }

        /// <summary>
        /// Only return subscription schedules for the given customer.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        /// <summary>
        /// Only return subscription schedules that were released during the given date interval.
        /// </summary>
        [JsonProperty("released_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("released_at")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> ReleasedAt { get; set; }

        /// <summary>
        /// Only return subscription schedules that have not started yet.
        /// </summary>
        [JsonProperty("scheduled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scheduled")]
#endif

        public bool? Scheduled { get; set; }
    }
}
