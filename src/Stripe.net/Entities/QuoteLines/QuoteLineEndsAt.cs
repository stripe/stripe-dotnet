// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineEndsAt : StripeEntity<QuoteLineEndsAt>
    {
        /// <summary>
        /// The timestamp value that will be used to determine when to make changes to the
        /// subscription schedule, as computed from the <c>ends_at</c> field. For example, if
        /// <c>ends_at[type]=upcoming_invoice</c>, the upcoming invoice date will be computed at the
        /// time the <c>ends_at</c> field was specified and saved. This field will not be recomputed
        /// upon future requests to update or finalize the quote unless <c>ends_at</c> is
        /// respecified. This field is guaranteed to be populated after quote acceptance.
        /// </summary>
        [JsonProperty("computed")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("computed")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Computed { get; set; }

        /// <summary>
        /// Use the <c>end</c> time of a given discount.
        /// </summary>
        [JsonProperty("discount_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_end")]
#endif
        public QuoteLineEndsAtDiscountEnd DiscountEnd { get; set; }

        /// <summary>
        /// Time span for the quote line starting from the <c>starts_at</c> date.
        /// </summary>
        [JsonProperty("duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duration")]
#endif
        public QuoteLineEndsAtDuration Duration { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select a way to pass in <c>ends_at</c>.
        /// One of: <c>billing_period_end</c>, <c>discount_end</c>, <c>duration</c>,
        /// <c>quote_acceptance_date</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
