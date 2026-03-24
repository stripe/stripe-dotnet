// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionLastPriceMigrationError : StripeEntity<SubscriptionLastPriceMigrationError>
    {
        /// <summary>
        /// The time at which the price migration encountered an error.
        /// </summary>
        [JsonProperty("errored_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("errored_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ErroredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The involved price pairs in each failed transition.
        /// </summary>
        [JsonProperty("failed_transitions")]
        [STJS.JsonPropertyName("failed_transitions")]
        public List<SubscriptionLastPriceMigrationErrorFailedTransition> FailedTransitions { get; set; }

        /// <summary>
        /// The type of error encountered by the price migration.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
