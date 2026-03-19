// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// ReservePlans are used to automatically place holds on a merchant's funds until the plan
    /// expires. It takes a portion of each incoming Charge (including those resulting from a
    /// Transfer from a platform account).
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Plan : StripeEntity<Plan>, IHasId, IHasMetadata, IHasObject
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
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Indicates which party created this ReservePlan.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("created_by")]
        [STJS.JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>. An unset currency indicates that the plan applies to all currencies.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Time at which the ReservePlan was disabled.
        /// </summary>
        [JsonProperty("disabled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("disabled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DisabledAt { get; set; }

        [JsonProperty("fixed_release")]
        [STJS.JsonPropertyName("fixed_release")]
        public PlanFixedRelease FixedRelease { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The percent of each Charge to reserve.
        /// </summary>
        [JsonProperty("percent")]
        [STJS.JsonPropertyName("percent")]
        public long Percent { get; set; }

        [JsonProperty("rolling_release")]
        [STJS.JsonPropertyName("rolling_release")]
        public PlanRollingRelease RollingRelease { get; set; }

        /// <summary>
        /// The current status of the ReservePlan. The ReservePlan only affects charges if it is
        /// <c>active</c>.
        /// One of: <c>active</c>, <c>disabled</c>, or <c>expired</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of the ReservePlan.
        /// One of: <c>fixed_release</c>, or <c>rolling_release</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
