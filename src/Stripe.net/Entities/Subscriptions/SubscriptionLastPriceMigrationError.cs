// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionLastPriceMigrationError : StripeEntity<SubscriptionLastPriceMigrationError>
    {
        /// <summary>
        /// The time at which the price migration encountered an error.
        /// </summary>
        [JsonProperty("errored_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errored_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ErroredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The involved price pairs in each failed transition.
        /// </summary>
        [JsonProperty("failed_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed_transitions")]
#endif
        public List<SubscriptionLastPriceMigrationErrorFailedTransition> FailedTransitions { get; set; }

        /// <summary>
        /// The type of error encountered by the price migration.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
