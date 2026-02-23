// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// ReserveReleases represent the release of funds from a ReserveHold.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Release : StripeEntity<Release>, IHasId, IHasMetadata, IHasObject
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
        /// Amount released. A positive integer representing how much is released in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Indicates which party created this ReserveRelease.
        /// One of: <c>application</c>, or <c>stripe</c>.
        /// </summary>
        [JsonProperty("created_by")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_by")]
#endif
        public string CreatedBy { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

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
        /// The reason for the ReserveRelease, indicating why the funds were released.
        /// One of: <c>bulk_hold_expiry</c>, <c>hold_released_early</c>, <c>hold_reversed</c>, or
        /// <c>plan_disabled</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// The release timestamp of the funds.
        /// </summary>
        [JsonProperty("released_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("released_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ReleasedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        #region Expandable ReserveHold

        /// <summary>
        /// (ID of the Hold)
        /// The ReserveHold this ReserveRelease is associated with.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Hold ReserveHold
        {
            get => this.InternalReserveHold?.ExpandedObject;
            set => this.InternalReserveHold = SetExpandableFieldObject(value, this.InternalReserveHold);
        }

        [JsonProperty("reserve_hold")]
        [JsonConverter(typeof(ExpandableFieldConverter<Hold>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserve_hold")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Hold>))]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Plan ReservePlan
        {
            get => this.InternalReservePlan?.ExpandedObject;
            set => this.InternalReservePlan = SetExpandableFieldObject(value, this.InternalReservePlan);
        }

        [JsonProperty("reserve_plan")]
        [JsonConverter(typeof(ExpandableFieldConverter<Plan>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserve_plan")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Plan>))]
#endif
        internal ExpandableField<Plan> InternalReservePlan { get; set; }
        #endregion

        [JsonProperty("source_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_transaction")]
#endif
        public ReleaseSourceTransaction SourceTransaction { get; set; }
    }
}
