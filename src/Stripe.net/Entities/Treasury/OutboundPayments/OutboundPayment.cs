// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Use <a
    /// href="https://docs.stripe.com/docs/treasury/moving-money/financial-accounts/out-of/outbound-payments">OutboundPayments</a>
    /// to send funds to another party's external bank account or <a
    /// href="https://api.stripe.com#financial_accounts">FinancialAccount</a>. To send money to
    /// an account belonging to the same user, use an <a
    /// href="https://api.stripe.com#outbound_transfers">OutboundTransfer</a>.
    ///
    /// Simulate OutboundPayment state changes with the
    /// <c>/v1/test_helpers/treasury/outbound_payments</c> endpoints. These methods can only be
    /// called on test mode objects.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/docs/treasury/moving-money/financial-accounts/out-of/outbound-payments">Moving
    /// money with Treasury using OutboundPayment objects</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class OutboundPayment : StripeEntity<OutboundPayment>, IHasId, IHasMetadata, IHasObject
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
        /// Amount (in cents) transferred.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Returns <c>true</c> if the object can be canceled, and <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("cancelable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancelable")]
#endif
        public bool Cancelable { get; set; }

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
        /// ID of the <a href="https://docs.stripe.com/api/customers">customer</a> to whom an
        /// OutboundPayment is sent.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The PaymentMethod via which an OutboundPayment is sent. This field can be empty if the
        /// OutboundPayment was created using <c>destination_payment_method_data</c>.
        /// </summary>
        [JsonProperty("destination_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment_method")]
#endif
        public string DestinationPaymentMethod { get; set; }

        /// <summary>
        /// Details about the PaymentMethod for an OutboundPayment.
        /// </summary>
        [JsonProperty("destination_payment_method_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment_method_details")]
#endif
        public OutboundPaymentDestinationPaymentMethodDetails DestinationPaymentMethodDetails { get; set; }

        /// <summary>
        /// Details about the end user.
        /// </summary>
        [JsonProperty("end_user_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_user_details")]
#endif
        public OutboundPaymentEndUserDetails EndUserDetails { get; set; }

        /// <summary>
        /// The date when funds are expected to arrive in the destination account.
        /// </summary>
        [JsonProperty("expected_arrival_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_arrival_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ExpectedArrivalDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The FinancialAccount that funds were pulled from.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/treasury/moving-money/regulatory-receipts">hosted
        /// transaction receipt</a> URL that is provided when money movement is considered regulated
        /// under Stripe's money transmission licenses.
        /// </summary>
        [JsonProperty("hosted_regulatory_receipt_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_regulatory_receipt_url")]
#endif
        public string HostedRegulatoryReceiptUrl { get; set; }

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
        /// Details about a returned OutboundPayment. Only set when the status is <c>returned</c>.
        /// </summary>
        [JsonProperty("returned_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("returned_details")]
#endif
        public OutboundPaymentReturnedDetails ReturnedDetails { get; set; }

        /// <summary>
        /// The description that appears on the receiving end for an OutboundPayment (for example,
        /// bank statement for external bank transfer).
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Current status of the OutboundPayment: <c>processing</c>, <c>failed</c>, <c>posted</c>,
        /// <c>returned</c>, <c>canceled</c>. An OutboundPayment is <c>processing</c> if it has been
        /// created and is pending. The status changes to <c>posted</c> once the OutboundPayment has
        /// been "confirmed" and funds have left the account, or to <c>failed</c> or
        /// <c>canceled</c>. If an OutboundPayment fails to arrive at its destination, its status
        /// will change to <c>returned</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("status_transitions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_transitions")]
#endif
        public OutboundPaymentStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// Details about network-specific tracking information if available.
        /// </summary>
        [JsonProperty("tracking_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tracking_details")]
#endif
        public OutboundPaymentTrackingDetails TrackingDetails { get; set; }

        #region Expandable Transaction

        /// <summary>
        /// (ID of the Transaction)
        /// The Transaction associated with this object.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string TransactionId
        {
            get => this.InternalTransaction?.Id;
            set => this.InternalTransaction = SetExpandableFieldId(value, this.InternalTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The Transaction associated with this object.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Transaction Transaction
        {
            get => this.InternalTransaction?.ExpandedObject;
            set => this.InternalTransaction = SetExpandableFieldObject(value, this.InternalTransaction);
        }

        [JsonProperty("transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Transaction>))]
#endif
        internal ExpandableField<Transaction> InternalTransaction { get; set; }
        #endregion
    }
}
