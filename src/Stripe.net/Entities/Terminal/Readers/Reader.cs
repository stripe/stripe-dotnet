// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Reader represents a physical device for accepting payment details.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/terminal/payments/connect-reader">Connecting to a
    /// reader</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Reader : StripeEntity<Reader>, IHasId, IHasMetadata, IHasObject
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
        /// The most recent action performed by the reader.
        /// </summary>
        [JsonProperty("action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("action")]
#endif
        public ReaderAction Action { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deleted")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
#endif
        public bool? Deleted { get; set; }

        /// <summary>
        /// The current software version of the reader.
        /// </summary>
        [JsonProperty("device_sw_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device_sw_version")]
#endif
        public string DeviceSwVersion { get; set; }

        /// <summary>
        /// Device type of the reader.
        /// One of: <c>bbpos_chipper2x</c>, <c>bbpos_wisepad3</c>, <c>bbpos_wisepos_e</c>,
        /// <c>mobile_phone_reader</c>, <c>simulated_stripe_s700</c>, <c>simulated_stripe_s710</c>,
        /// <c>simulated_wisepos_e</c>, <c>stripe_m2</c>, <c>stripe_s700</c>, <c>stripe_s710</c>, or
        /// <c>verifone_P400</c>.
        /// </summary>
        [JsonProperty("device_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("device_type")]
#endif
        public string DeviceType { get; set; }

        /// <summary>
        /// The local IP address of the reader.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif
        public string IpAddress { get; set; }

        /// <summary>
        /// Custom label given to the reader for easier identification.
        /// </summary>
        [JsonProperty("label")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("label")]
#endif
        public string Label { get; set; }

        /// <summary>
        /// The last time this reader reported to Stripe backend. Timestamp is measured in
        /// milliseconds since the Unix epoch. Unlike most other Stripe timestamp fields which use
        /// seconds, this field uses milliseconds.
        /// </summary>
        [JsonProperty("last_seen_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_seen_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? LastSeenAt { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        #region Expandable Location

        /// <summary>
        /// (ID of the Location)
        /// The location identifier of the reader.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string LocationId
        {
            get => this.InternalLocation?.Id;
            set => this.InternalLocation = SetExpandableFieldId(value, this.InternalLocation);
        }

        /// <summary>
        /// (Expanded)
        /// The location identifier of the reader.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Location Location
        {
            get => this.InternalLocation?.ExpandedObject;
            set => this.InternalLocation = SetExpandableFieldObject(value, this.InternalLocation);
        }

        [JsonProperty("location")]
        [JsonConverter(typeof(ExpandableFieldConverter<Location>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Location>))]
#endif
        internal ExpandableField<Location> InternalLocation { get; set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Serial number of the reader.
        /// </summary>
        [JsonProperty("serial_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("serial_number")]
#endif
        public string SerialNumber { get; set; }

        /// <summary>
        /// The networking status of the reader. We do not recommend using this field in flows that
        /// may block taking payments.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
