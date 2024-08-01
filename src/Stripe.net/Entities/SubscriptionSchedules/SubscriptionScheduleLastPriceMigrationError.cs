// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleLastPriceMigrationError : StripeEntity<SubscriptionScheduleLastPriceMigrationError>
    {
        /// <summary>
        /// The time at which the price migration encountered an error.
        /// </summary>
        [JsonProperty("errored_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ErroredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The involved price pairs in each failed transition.
        /// </summary>
        [JsonProperty("failed_transitions")]
        public List<SubscriptionScheduleLastPriceMigrationErrorFailedTransition> FailedTransitions { get; set; }

        /// <summary>
        /// The type of error encountered by the price migration.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
