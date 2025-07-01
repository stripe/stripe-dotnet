// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// OutboundTransfer represents a single money movement from one FinancialAccount you own to
    /// a payout method you also own.
    /// </summary>
    public class OutboundTransfer : StripeEntity<OutboundTransfer>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the OutboundTransfer.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The "presentment amount" for the OutboundTransfer.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Returns true if the OutboundTransfer can be canceled, and false otherwise.
        /// </summary>
        [JsonProperty("cancelable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancelable")]
#endif
        public bool Cancelable { get; set; }

        /// <summary>
        /// Time at which the OutboundTransfer was created. Represented as a RFC 3339 date &amp;
        /// time UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Delivery options to be used to send the OutboundTransfer.
        /// </summary>
        [JsonProperty("delivery_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivery_options")]
#endif
        public OutboundTransferDeliveryOptions DeliveryOptions { get; set; }

        /// <summary>
        /// An arbitrary string attached to the OutboundTransfer. Often useful for displaying to
        /// users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The date when funds are expected to arrive in the payout method. This field is not set
        /// if the payout method is in a <c>failed</c>, <c>canceled</c>, or <c>returned</c> state.
        /// Represented as a RFC 3339 date &amp; time UTC value in millisecond precision, for
        /// example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("expected_arrival_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_arrival_date")]
#endif
        public DateTime? ExpectedArrivalDate { get; set; }

        /// <summary>
        /// The FinancialAccount that funds were pulled from.
        /// </summary>
        [JsonProperty("from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from")]
#endif
        public OutboundTransferFrom From { get; set; }

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
        /// Set of key-value pairs that you can attach to an object. This can be useful for storing
        /// additional information about the object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A link to the Stripe-hosted receipt for this OutboundTransfer. The receipt link remains
        /// active for 60 days from the OutboundTransfer creation date. After this period, the link
        /// will expire and the receipt url value will be null.
        /// </summary>
        [JsonProperty("receipt_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("receipt_url")]
#endif
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// The description that appears on the receiving end for an OutboundTransfer (for example,
        /// bank statement for external bank transfer). It will default to <c>STRIPE</c> if not set
        /// on the account settings.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Status details for an OutboundTransfer in a <c>failed</c> or <c>returned</c> state.
        /// </summary>
        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public OutboundTransferStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Hash containing timestamps of when the object transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif
        public OutboundTransferStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// To which payout method the OutboundTransfer was sent.
        /// </summary>
        [JsonProperty("to")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to")]
#endif
        public OutboundTransferTo To { get; set; }

        /// <summary>
        /// A unique identifier that can be used to track this OutboundTransfer with recipient bank.
        /// Banks might call this a “reference number” or something similar.
        /// </summary>
        [JsonProperty("trace_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trace_id")]
#endif
        public OutboundTransferTraceId TraceId { get; set; }
    }
}
