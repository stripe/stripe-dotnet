// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePrebillingBillUntilOptions : INestedOptions
    {
        /// <summary>
        /// End the prebilled period when a specified amendment ends.
        /// </summary>
        [JsonProperty("amendment_end")]
        [STJS.JsonPropertyName("amendment_end")]
        public SubscriptionSchedulePrebillingBillUntilAmendmentEndOptions AmendmentEnd { get; set; }

        /// <summary>
        /// Time span for prebilling, starting from <c>bill_from</c>.
        /// </summary>
        [JsonProperty("duration")]
        [STJS.JsonPropertyName("duration")]
        public SubscriptionSchedulePrebillingBillUntilDurationOptions Duration { get; set; }

        /// <summary>
        /// End the prebilled period at a precise integer timestamp, starting from the Unix epoch.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select one of several ways to pass the <c>bill_until</c> value.
        /// One of: <c>amendment_end</c>, <c>duration</c>, <c>schedule_end</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
