// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// ReserveHolds are used to place a temporary ReserveHold on a merchant's funds.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Hold : StripeEntity<Hold>, IHasId, IHasMetadata, IHasObject
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
        /// Amount reserved. A positive integer representing how much is reserved in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Amount in cents that can be released from this ReserveHold.
        /// </summary>
        [JsonProperty("amount_releasable")]
        [STJS.JsonPropertyName("amount_releasable")]
        public long AmountReleasable { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Indicates which party created this ReserveHold.
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
        /// Whether there are any funds available to release on this ReserveHold. Note that if the
        /// ReserveHold is in the process of being released, this could be false, even though the
        /// funds haven't been fully released yet.
        /// </summary>
        [JsonProperty("is_releasable")]
        [STJS.JsonPropertyName("is_releasable")]
        public bool IsReleasable { get; set; }

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
        /// The reason for the ReserveHold.
        /// One of: <c>charge</c>, or <c>standalone</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonProperty("release_schedule")]
        [STJS.JsonPropertyName("release_schedule")]
        public HoldReleaseSchedule ReleaseSchedule { get; set; }

        #region Expandable ReservePlan

        /// <summary>
        /// (ID of the Plan)
        /// The ReservePlan which produced this ReserveHold (i.e., resplan_123).
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
        /// The ReservePlan which produced this ReserveHold (i.e., resplan_123).
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

        #region Expandable SourceCharge

        /// <summary>
        /// (ID of the Charge)
        /// The Charge which funded this ReserveHold (e.g., ch_123).
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string SourceChargeId
        {
            get => this.InternalSourceCharge?.Id;
            set => this.InternalSourceCharge = SetExpandableFieldId(value, this.InternalSourceCharge);
        }

        /// <summary>
        /// (Expanded)
        /// The Charge which funded this ReserveHold (e.g., ch_123).
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Charge SourceCharge
        {
            get => this.InternalSourceCharge?.ExpandedObject;
            set => this.InternalSourceCharge = SetExpandableFieldObject(value, this.InternalSourceCharge);
        }

        [JsonProperty("source_charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        [STJS.JsonPropertyName("source_charge")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalSourceCharge { get; set; }
        #endregion

        /// <summary>
        /// Which source balance type this ReserveHold reserves funds from. One of
        /// <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// One of: <c>bank_account</c>, <c>card</c>, or <c>fpx</c>.
        /// </summary>
        [JsonProperty("source_type")]
        [STJS.JsonPropertyName("source_type")]
        public string SourceType { get; set; }
    }
}
