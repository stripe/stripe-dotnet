namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Dispute : StripeEntity<Dispute>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Disputed amount. Usually the amount of the charge, but can differ (usually because of
        /// currency fluctuation or because only part of the order is disputed).
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// List of zero, one, or two balance transactions that show funds withdrawn and reinstated
        /// to your Stripe account as a result of this dispute.
        /// </summary>
        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge that was disputed.
        /// </summary>
        [JsonIgnore]
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the charge that was disputed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("evidence")]
        public DisputeEvidence Evidence { get; set; }

        [JsonProperty("evidence_details")]
        public DisputeEvidenceDetails EvidenceDetails { get; set; }

        /// <summary>
        /// If true, it is still possible to refund the disputed payment. Once the payment has been
        /// fully refunded, no further funds will be withdrawn from your Stripe account as a result
        /// of this dispute.
        /// </summary>
        [JsonProperty("is_charge_refundable")]
        public bool IsChargeRefundable { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Network-dependent reason code for the dispute.
        /// </summary>
        [JsonProperty("network_reason_code")]
        public string NetworkReasonCode { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the PaymentIntent that was disputed.
        /// </summary>
        [JsonIgnore]
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the PaymentIntent that was disputed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        /// <summary>
        /// Reason given by cardholder for dispute. Possible values are <c>bank_cannot_process</c>,
        /// <c>check_returned</c>, <c>credit_not_processed</c>, <c>customer_initiated</c>,
        /// <c>debit_not_authorized</c>, <c>duplicate</c>, <c>fraudulent</c>, <c>general</c>,
        /// <c>incorrect_account_details</c>, <c>insufficient_funds</c>,
        /// <c>product_not_received</c>, <c>product_unacceptable</c>, <c>subscription_canceled</c>,
        /// or <c>unrecognized</c>. Read more about <a
        /// href="https://stripe.com/docs/disputes/categories">dispute reasons</a>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Current status of dispute. Possible values are <c>warning_needs_response</c>,
        /// <c>warning_under_review</c>, <c>warning_closed</c>, <c>needs_response</c>,
        /// <c>under_review</c>, <c>charge_refunded</c>, <c>won</c>, or <c>lost</c>.
        /// One of: <c>charge_refunded</c>, <c>lost</c>, <c>needs_response</c>, <c>under_review</c>,
        /// <c>warning_closed</c>, <c>warning_needs_response</c>, <c>warning_under_review</c>, or
        /// <c>won</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
