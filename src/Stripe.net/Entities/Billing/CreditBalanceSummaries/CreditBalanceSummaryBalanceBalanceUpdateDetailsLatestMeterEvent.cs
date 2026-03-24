// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditBalanceSummaryBalanceBalanceUpdateDetailsLatestMeterEvent : StripeEntity<CreditBalanceSummaryBalanceBalanceUpdateDetailsLatestMeterEvent>
    {
        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Maximum event time across all meter events that were processed and included in the
        /// balance update. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Timestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
