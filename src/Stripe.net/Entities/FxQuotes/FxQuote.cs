// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The FX Quotes API provides three functions: - View Stripe's current exchange rate for
    /// any given currency pair. - Extend quoted rates for a 1-hour period or a 24-hour period,
    /// minimizing uncertainty from FX fluctuations. - Preview the FX fees Stripe will charge on
    /// your FX transaction, allowing you to anticipate specific settlement amounts before
    /// payment costs.
    ///
    /// <a href="https://stripe.com/payments/currencies/localize-prices/fx-quotes-api">View the
    /// docs</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FxQuote : StripeEntity<FxQuote>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the quote was created, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The duration the exchange rate quote remains valid from creation time. Allowed values
        /// are none, hour, and day. Note that for the test mode API available in alpha, you can
        /// request an extended quote, but it won't be usable for any transactions.
        /// One of: <c>day</c>, <c>five_minutes</c>, <c>hour</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("lock_duration")]
        [STJS.JsonPropertyName("lock_duration")]
        public string LockDuration { get; set; }

        /// <summary>
        /// Time at which the quote will expire, measured in seconds since the Unix epoch.
        ///
        /// If lock_duration is set to ‘none’ this field will be set to null.
        /// </summary>
        [JsonProperty("lock_expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("lock_expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? LockExpiresAt { get; set; }

        /// <summary>
        /// Lock status of the quote. Transitions from active to expired once past the
        /// lock_expires_at timestamp.
        ///
        /// Can return value none, active, or expired.
        /// One of: <c>active</c>, <c>expired</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("lock_status")]
        [STJS.JsonPropertyName("lock_status")]
        public string LockStatus { get; set; }

        /// <summary>
        /// Information about the rates.
        /// </summary>
        [JsonProperty("rates")]
        [STJS.JsonPropertyName("rates")]
        public Dictionary<string, FxQuoteRates> Rates { get; set; }

        /// <summary>
        /// The currency to convert into, typically this is the currency that you want to settle to
        /// your Stripe balance. Three-letter ISO currency code, in lowercase. Must be a supported
        /// currency.
        /// </summary>
        [JsonProperty("to_currency")]
        [STJS.JsonPropertyName("to_currency")]
        public string ToCurrency { get; set; }

        [JsonProperty("usage")]
        [STJS.JsonPropertyName("usage")]
        public FxQuoteUsage Usage { get; set; }
    }
}
