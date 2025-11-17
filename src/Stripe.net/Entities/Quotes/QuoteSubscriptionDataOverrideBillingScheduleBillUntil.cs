// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteSubscriptionDataOverrideBillingScheduleBillUntil : StripeEntity<QuoteSubscriptionDataOverrideBillingScheduleBillUntil>
    {
        /// <summary>
        /// Use an index to specify the position of an amendment to end prebilling with.
        /// </summary>
        [JsonProperty("amendment_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amendment_end")]
#endif
        public QuoteSubscriptionDataOverrideBillingScheduleBillUntilAmendmentEnd AmendmentEnd { get; set; }

        /// <summary>
        /// The timestamp the billing schedule will apply until.
        /// </summary>
        [JsonProperty("computed_timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("computed_timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ComputedTimestamp { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Specifies the billing period.
        /// </summary>
        [JsonProperty("duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration")]
#endif
        public QuoteSubscriptionDataOverrideBillingScheduleBillUntilDuration Duration { get; set; }

        /// <summary>
        /// Lets you bill the period ending at a particular Quote line.
        /// </summary>
        [JsonProperty("line_ends_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_ends_at")]
#endif
        public QuoteSubscriptionDataOverrideBillingScheduleBillUntilLineEndsAt LineEndsAt { get; set; }

        /// <summary>
        /// If specified, the billing schedule will apply until the specified timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Describes how the billing schedule will determine the end date. Either <c>duration</c>
        /// or <c>timestamp</c>.
        /// One of: <c>amendment_end</c>, <c>duration</c>, <c>line_ends_at</c>, <c>schedule_end</c>,
        /// <c>timestamp</c>, or <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
