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

    /// <summary>
    /// The FX Quotes API provides three key functions: - View current exchange rates: The
    /// object shows Stripe's current exchange rate for any given currency pair. - Extended
    /// quotes: The API provides rate quotes valid for a 1-hour period or a 24-hour period,
    /// eliminating uncertainty from FX fluctuations. - View FX fees: The API provides
    /// information on the FX fees Stripe will charge on your FX transaction, allowing you to
    /// anticipate specific settlement amounts before payment costs.
    /// </summary>
    public class FxQuote : StripeEntity<FxQuote>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Time at which the quote was created, measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The duration the exchange rate quote remains valid from creation time. Allowed values
        /// are none, hour, and day. Note that for the test mode API available in alpha, you can
        /// request an extended quote, but it won't be usable for any transactions.
        /// One of: <c>day</c>, <c>five_minutes</c>, <c>hour</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("lock_duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lock_duration")]
#endif
        public string LockDuration { get; set; }

        /// <summary>
        /// Time at which the quote will expire, measured in seconds since the Unix epoch.
        ///
        /// If lock_duration is set to ‘none’ this field will be set to null.
        /// </summary>
        [JsonProperty("lock_expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lock_expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? LockExpiresAt { get; set; }

        /// <summary>
        /// Lock status of the quote. Transitions from active to expired once past the
        /// lock_expires_at timestamp.
        ///
        /// Can return value none, active, or expired.
        /// One of: <c>active</c>, <c>expired</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("lock_status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lock_status")]
#endif
        public string LockStatus { get; set; }

        /// <summary>
        /// Information about the rates.
        /// </summary>
        [JsonProperty("rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rates")]
#endif
        public Dictionary<string, FxQuoteRates> Rates { get; set; }

        /// <summary>
        /// The currency to convert into, typically this is the currency that you want to settle to
        /// your Stripe balance. Three-letter ISO currency code, in lowercase. Must be a supported
        /// currency.
        /// </summary>
        [JsonProperty("to_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to_currency")]
#endif
        public string ToCurrency { get; set; }

        [JsonProperty("usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage")]
#endif
        public FxQuoteUsage Usage { get; set; }
    }
}
