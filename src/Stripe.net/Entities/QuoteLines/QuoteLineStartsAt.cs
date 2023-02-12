// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteLineStartsAt : StripeEntity<QuoteLineStartsAt>
    {
        /// <summary>
        /// The timestamp value that will be used to determine when to make changes to the
        /// subscription schedule, as computed from the <c>starts_at</c> field. For example, if
        /// <c>starts_at[type]=upcoming_invoice</c>, the upcoming invoice date will be computed at
        /// the time the <c>starts_at</c> field was specified and saved. This field will not be
        /// recomputed upon future requests to update or finalize the quote unless <c>starts_at</c>
        /// is respecified. This field is guaranteed to be populated after quote acceptance.
        /// </summary>
        [JsonProperty("computed")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Computed { get; set; }

        /// <summary>
        /// Use the <c>end</c> time of a given discount.
        /// </summary>
        [JsonProperty("discount_end")]
        public QuoteLineStartsAtDiscountEnd DiscountEnd { get; set; }

        /// <summary>
        /// The timestamp the given line ends at.
        /// </summary>
        [JsonProperty("line_ends_at")]
        public QuoteLineStartsAtLineEndsAt LineEndsAt { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Select a way to pass in <c>starts_at</c>.
        /// One of: <c>discount_end</c>, <c>line_ends_at</c>, <c>now</c>,
        /// <c>quote_acceptance_date</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
