// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// An InboundTransferMandate represents Stripe's authorization to debit a merchant's
    /// external bank account (v2 credential) on their behalf.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferMandate : StripeEntity<InboundTransferMandate>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the InboundTransferMandate.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Australian BECS-specific details. Present when type is AU_BECS.
        /// </summary>
        [JsonProperty("au_becs")]
        [STJS.JsonPropertyName("au_becs")]
        public InboundTransferMandateAuBecs AuBecs { get; set; }

        /// <summary>
        /// Bacs-specific details. Present when type is BACS.
        /// </summary>
        [JsonProperty("bacs")]
        [STJS.JsonPropertyName("bacs")]
        public InboundTransferMandateBacs Bacs { get; set; }

        /// <summary>
        /// Creation time of the mandate. RFC 3339 UTC, millisecond precision.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The v2 credential (e.g. GB Bank Account) this mandate authorizes debits for.
        /// </summary>
        [JsonProperty("credential")]
        [STJS.JsonPropertyName("credential")]
        public string Credential { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The current lifecycle status of the mandate.
        /// One of: <c>active</c>, <c>canceled</c>, <c>expired</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Additional details about the current status (e.g. cancelation reason).
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public InboundTransferMandateStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Timestamps for each state transition.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public InboundTransferMandateStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The mandate scheme type.
        /// One of: <c>au_becs</c>, <c>bacs</c>, <c>nz_becs</c>, or <c>sepa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Evidence of the merchant's acceptance of the mandate.
        /// </summary>
        [JsonProperty("user_accepted_details")]
        [STJS.JsonPropertyName("user_accepted_details")]
        public InboundTransferMandateUserAcceptedDetails UserAcceptedDetails { get; set; }
    }
}
