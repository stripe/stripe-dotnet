// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// OutboundPayment represents a single money movement from one FinancialAccount you own to
    /// a payout method someone else owns.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPayment : StripeEntity<OutboundPayment>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the OutboundPayment.
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
        /// The "presentment amount" for the OutboundPayment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Returns true if the OutboundPayment can be canceled, and false otherwise.
        /// </summary>
        [JsonProperty("cancelable")]
        [STJS.JsonPropertyName("cancelable")]
        public bool Cancelable { get; set; }

        /// <summary>
        /// Time at which the OutboundPayment was created. Represented as a RFC 3339 date &amp; time
        /// UTC value in millisecond precision, for example: 2022-09-18T13:22:18.123Z.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Delivery options to be used to send the OutboundPayment.
        /// </summary>
        [JsonProperty("delivery_options")]
        [STJS.JsonPropertyName("delivery_options")]
        public OutboundPaymentDeliveryOptions DeliveryOptions { get; set; }

        /// <summary>
        /// An arbitrary string attached to the OutboundPayment. Often useful for displaying to
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
        public OutboundPaymentFrom From { get; set; }

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
        /// The quote for this OutboundPayment. Only required for countries with regulatory mandates
        /// to display fee estimates before OutboundPayment creation.
        /// </summary>
        [JsonProperty("outbound_payment_quote")]
        [STJS.JsonPropertyName("outbound_payment_quote")]
        public string OutboundPaymentQuote { get; set; }

        /// <summary>
        /// The purpose of the OutboundPayment.
        /// </summary>
        [JsonProperty("purpose")]
        [STJS.JsonPropertyName("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// A link to the Stripe-hosted receipt for this OutboundPayment. The receipt link remains
        /// active for 60 days from the OutboundPayment creation date. After this period, the link
        /// will expire and the receipt url value will be null.
        /// </summary>
        [JsonProperty("receipt_url")]
        [STJS.JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// Details about the OutboundPayment notification settings for recipient.
        /// </summary>
        [JsonProperty("recipient_notification")]
        [STJS.JsonPropertyName("recipient_notification")]
        public OutboundPaymentRecipientNotification RecipientNotification { get; set; }

        /// <summary>
        /// The recipient verification id for this OutboundPayment. Only required for countries with
        /// regulatory mandates to verify recipient names before OutboundPayment creation.
        /// </summary>
        [JsonProperty("recipient_verification")]
        [STJS.JsonPropertyName("recipient_verification")]
        public string RecipientVerification { get; set; }

        /// <summary>
        /// The description that appears on the receiving end for an OutboundPayment (for example,
        /// bank statement for external bank transfer). It will default to <c>STRIPE</c> if not set
        /// on the account settings.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Closed Enum. Current status of the OutboundPayment: <c>processing</c>, <c>failed</c>,
        /// <c>posted</c>, <c>returned</c>, <c>canceled</c>. An OutboundPayment is <c>processing</c>
        /// if it has been created and is processing. The status changes to <c>posted</c> once the
        /// OutboundPayment has been "confirmed" and funds have left the account, or to
        /// <c>failed</c> or <c>canceled</c>. If an OutboundPayment fails to arrive at its payout
        /// method, its status will change to <c>returned</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Status details for an OutboundPayment in a <c>failed</c> or <c>returned</c> state.
        /// </summary>
        [JsonProperty("status_details")]
        [STJS.JsonPropertyName("status_details")]
        public OutboundPaymentStatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Hash containing timestamps of when the object transitioned to a particular status.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public OutboundPaymentStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// To which payout method the OutboundPayment was sent.
        /// </summary>
        [JsonProperty("to")]
        [STJS.JsonPropertyName("to")]
        public OutboundPaymentTo To { get; set; }

        /// <summary>
        /// A unique identifier that can be used to track this OutboundPayment with recipient bank.
        /// Banks might call this a "reference number" or something similar.
        /// </summary>
        [JsonProperty("trace_id")]
        [STJS.JsonPropertyName("trace_id")]
        public OutboundPaymentTraceId TraceId { get; set; }

        /// <summary>
        /// Information to track this OutboundPayment with the recipient bank.
        /// </summary>
        [JsonProperty("tracking_details")]
        [STJS.JsonPropertyName("tracking_details")]
        public OutboundPaymentTrackingDetails TrackingDetails { get; set; }
    }
}
