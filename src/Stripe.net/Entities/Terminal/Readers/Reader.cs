// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Reader represents a physical device for accepting payment details.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/terminal/payments/connect-reader">Connecting to a
    /// reader</a>.
    /// </summary>
    public class Reader : StripeEntity<Reader>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The most recent action performed by the reader.
        /// </summary>
        [JsonProperty("action")]
        public ReaderAction Action { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The current software version of the reader.
        /// </summary>
        [JsonProperty("device_sw_version")]
        public string DeviceSwVersion { get; set; }

        /// <summary>
        /// Type of reader, one of <c>bbpos_wisepad3</c>, <c>stripe_m2</c>, <c>bbpos_chipper2x</c>,
        /// <c>bbpos_wisepos_e</c>, <c>verifone_P400</c>, or <c>simulated_wisepos_e</c>.
        /// One of: <c>bbpos_chipper2x</c>, <c>bbpos_wisepad3</c>, <c>bbpos_wisepos_e</c>,
        /// <c>simulated_wisepos_e</c>, <c>stripe_m2</c>, or <c>verifone_P400</c>.
        /// </summary>
        [JsonProperty("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// The local IP address of the reader.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Custom label given to the reader for easier identification.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Location

        /// <summary>
        /// (ID of the Location)
        /// The location identifier of the reader.
        /// </summary>
        [JsonIgnore]
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
        public Location Location
        {
            get => this.InternalLocation?.ExpandedObject;
            set => this.InternalLocation = SetExpandableFieldObject(value, this.InternalLocation);
        }

        [JsonProperty("location")]
        [JsonConverter(typeof(ExpandableFieldConverter<Location>))]
        internal ExpandableField<Location> InternalLocation { get; set; }
        #endregion

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Serial number of the reader.
        /// </summary>
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// The networking status of the reader.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
