// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// OutboundTransfer represents a single money movement from one FinancialAccount you own to
    /// a payout method you also own.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundTransfer : StripeEntity<OutboundTransfer>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the OutboundTransfer.
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
        /// The "presentment amount" for the OutboundTransfer.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Returns true if the OutboundTransfer can be canceled, and false otherwise.
        /// </summary>
        [JsonProperty("cancelable")]
        [STJS.JsonPropertyName("cancelable")]
        public bool Cancelable { get; set; }

        /// <summary>
        /// Time at which the OutboundTransfer was created. Represented as a RFC 3339 date &amp;
        /// time UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Delivery options to be used to send the OutboundTransfer.
        /// </summary>
        [JsonProperty("delivery_options")]
        [STJS.JsonPropertyName("delivery_options")]
        public OutboundTransferDeliveryOptions DeliveryOptions { get; set; }

        /// <summary>
        /// An arbitrary string attached to the OutboundTransfer. Often useful for displaying to
        /// users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The date when funds are expected to arrive in the payout method. This field is not set
        /// if the payout method is in a <c>failed</c>, <c>canceled</c>, or <c>returned</c> state.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("expected_arrival_date")]
        [STJS.JsonPropertyName("expected_arrival_date")]
        public DateTime? ExpectedArrivalDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The FinancialAccount that funds were pulled from.
        /// </summary>
        [JsonProperty("from")]
        [STJS.JsonPropertyName("from")]
        public OutboundTransferFrom From { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A link to the Stripe-hosted receipt for this OutboundTransfer. The receipt link remains
        /// active for 60 days from the OutboundTransfer creation date. After this period, the link
        /// will expire and the receipt url value will be null.
        /// </summary>
        [JsonProperty("receipt_url")]
        [STJS.JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// The recipient verification id for this OutboundTransfer. Only required for countries
        /// with regulatory mandates to verify recipient names before OutboundTransfer creation.
        /// </summary>
        [JsonProperty("recipient_verification")]
        [STJS.JsonPropertyName("recipient_verification")]
        public string RecipientVerification { get; set; }

        /// <summary>
        /// The description that appears on the receiving end for an OutboundTransfer (for example,
        /// bank statement for external bank transfer). It will default to <c>STRIPE</c> if not set
        /// on the account settings.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Closed Enum. Current status of the OutboundTransfer: <c>processing</c>, <c>failed</c>,
        /// <c>posted</c>, <c>returned</c>, <c>canceled</c>. An OutboundTransfer is
        /// <c>processing</c> if it has been created and is processing. The status changes to
        /// <c>posted</c> once the OutboundTransfer has been "confirmed" and funds have left the
        /// account, or to <c>failed</c> or <c>canceled</c>. If an OutboundTransfer fails to arrive
        /// at its payout method, its status will change to <c>returned</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Status details for an OutboundTransfer in a <c>failed</c> or <c>returned</c> state.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public OutboundTransferStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Hash containing timestamps of when the object transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public OutboundTransferStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// To which payout method the OutboundTransfer was sent.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public OutboundTransferTo To { get; set; }

        /// <summary>
        /// A unique identifier that can be used to track this OutboundTransfer with recipient bank.
        /// Banks might call this a "reference number" or something similar.
        /// </summary>
        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public OutboundTransferTraceId TraceId { get; set; }
    }
}
