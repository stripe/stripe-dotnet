// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// ReserveReleases represent the release of funds from a ReserveHold.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Release : StripeEntity<Release>, IHasId, IHasMetadata, IHasObject
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
        /// Amount released. A positive integer representing how much is released in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Indicates which party created this ReserveRelease.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("created_by")]
        [STJS.JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
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
        /// The reason for the ReserveRelease, indicating why the funds were released.
        /// One of: <c>bulk_hold_expiry</c>, <c>hold_released_early</c>, <c>hold_reversed</c>, or
        /// <c>plan_disabled</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The release timestamp of the funds.
        /// </summary>
        [JsonProperty("released_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("released_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ReleasedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable ReserveHold

        /// <summary>
        /// (ID of the Hold)
        /// The ReserveHold this ReserveRelease is associated with.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string ReserveHoldId
        {
            get => this.InternalReserveHold?.Id;
            set => this.InternalReserveHold = SetExpandableFieldId(value, this.InternalReserveHold);
        }

        /// <summary>
        /// (Expanded)
        /// The ReserveHold this ReserveRelease is associated with.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Hold ReserveHold
        {
            get => this.InternalReserveHold?.ExpandedObject;
            set => this.InternalReserveHold = SetExpandableFieldObject(value, this.InternalReserveHold);
        }

        [JsonProperty("reserve_hold")]
        [JsonConverter(typeof(ExpandableFieldConverter<Hold>))]
        [STJS.JsonPropertyName("reserve_hold")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Hold>))]
        internal ExpandableField<Hold> InternalReserveHold { get; set; }
        #endregion

        #region Expandable ReservePlan

        /// <summary>
        /// (ID of the Plan)
        /// The ReservePlan ID this ReserveRelease is associated with. This field is only populated
        /// if a ReserveRelease is created by a ReservePlan disable operation, or from a scheduled
        /// ReservedHold expiry.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string ReservePlanId
        {
            get => this.InternalReservePlan?.Id;
            set => this.InternalReservePlan = SetExpandableFieldId(value, this.InternalReservePlan);
        }

        /// <summary>
        /// (Expanded)
        /// The ReservePlan ID this ReserveRelease is associated with. This field is only populated
        /// if a ReserveRelease is created by a ReservePlan disable operation, or from a scheduled
        /// ReservedHold expiry.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Plan ReservePlan
        {
            get => this.InternalReservePlan?.ExpandedObject;
            set => this.InternalReservePlan = SetExpandableFieldObject(value, this.InternalReservePlan);
        }

        [JsonProperty("reserve_plan")]
        [JsonConverter(typeof(ExpandableFieldConverter<Plan>))]
        [STJS.JsonPropertyName("reserve_plan")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Plan>))]
        internal ExpandableField<Plan> InternalReservePlan { get; set; }
        #endregion

        [JsonProperty("source_transaction")]
        [STJS.JsonPropertyName("source_transaction")]
        public ReleaseSourceTransaction SourceTransaction { get; set; }
    }
}
