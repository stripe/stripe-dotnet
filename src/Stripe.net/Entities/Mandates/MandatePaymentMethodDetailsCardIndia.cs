// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MandatePaymentMethodDetailsCardIndia : StripeEntity<MandatePaymentMethodDetailsCardIndia>
    {
        /// <summary>
        /// The registered amount in the smallest currency unit. For a maximum amount mandate, this
        /// is the authorized ceiling.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Whether the registered amount is fixed or a maximum.
        /// One of: <c>fixed</c>, or <c>maximum</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("amount_type")]
        [STJS.JsonPropertyName("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The stored mandate description, before SIHub registration removes non-alphanumeric
        /// characters.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The registered end date, represented as midnight in India Standard Time, if specified.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("end_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The reason why the mandate has an <c>inactive</c> status. This field is only populated
        /// if the mandate is inactive.
        /// One of: <c>canceled</c>, <c>card_not_supported</c>, <c>currency_not_supported</c>,
        /// <c>expired</c>, <c>issuer_not_supported</c>, <c>processing_error</c>, or
        /// <c>undetermined</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("inactive_reason")]
        [STJS.JsonPropertyName("inactive_reason")]
        public string InactiveReason { get; set; }

        /// <summary>
        /// The registered payment interval. This can differ from the interval originally requested.
        /// One of: <c>day</c>, <c>month</c>, <c>sporadic</c>, <c>week</c>, or <c>year</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("interval")]
        [STJS.JsonPropertyName("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between registered payments. Null for sporadic mandates.
        /// </summary>
        [JsonProperty("interval_count")]
        [STJS.JsonPropertyName("interval_count")]
        public long? IntervalCount { get; set; }

        /// <summary>
        /// The reference registered for this mandate.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// The registered start date, represented as midnight in India Standard Time.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("start_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime StartDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
