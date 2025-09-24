// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A dispute occurs when a customer questions your charge with their card issuer. When this
    /// happens, you have the opportunity to respond to the dispute with evidence that shows
    /// that the charge is legitimate.
    ///
    /// Related guide: <a href="https://stripe.com/docs/disputes">Disputes and fraud</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Dispute : StripeEntity<Dispute>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Disputed amount. Usually the amount of the charge, but it can differ (usually because of
        /// currency fluctuation or because only part of the order is disputed).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// List of zero, one, or two balance transactions that show funds withdrawn and reinstated
        /// to your Stripe account as a result of this dispute.
        /// </summary>
        [JsonProperty("balance_transactions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_transactions")]
#endif
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        #region Expandable Charge

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge that's disputed.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ChargeId
        {
            get => this.InternalCharge?.Id;
            set => this.InternalCharge = SetExpandableFieldId(value, this.InternalCharge);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the charge that's disputed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Charge Charge
        {
            get => this.InternalCharge?.ExpandedObject;
            set => this.InternalCharge = SetExpandableFieldObject(value, this.InternalCharge);
        }

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

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
        /// List of eligibility types that are included in <c>enhanced_evidence</c>.
        /// One of: <c>visa_compelling_evidence_3</c>, or <c>visa_compliance</c>.
        /// </summary>
        [JsonProperty("enhanced_eligibility_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enhanced_eligibility_types")]
#endif
        public List<string> EnhancedEligibilityTypes { get; set; }

        [JsonProperty("evidence")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("evidence")]
#endif
        public DisputeEvidence Evidence { get; set; }

        [JsonProperty("evidence_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("evidence_details")]
#endif
        public DisputeEvidenceDetails EvidenceDetails { get; set; }

        /// <summary>
        /// Intended submission method for the dispute.
        /// One of: <c>manual</c>, <c>prefer_manual</c>, <c>prefer_smart_disputes</c>, or
        /// <c>smart_disputes</c>.
        /// </summary>
        [JsonProperty("intended_submission_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("intended_submission_method")]
#endif
        public string IntendedSubmissionMethod { get; set; }

        /// <summary>
        /// If true, it's still possible to refund the disputed payment. After the payment has been
        /// fully refunded, no further funds are withdrawn from your Stripe account as a result of
        /// this dispute.
        /// </summary>
        [JsonProperty("is_charge_refundable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_charge_refundable")]
#endif
        public bool IsChargeRefundable { get; set; }

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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Network-dependent reason code for the dispute.
        /// </summary>
        [JsonProperty("network_reason_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_reason_code")]
#endif
        public string NetworkReasonCode { get; set; }

        #region Expandable PaymentIntent

        /// <summary>
        /// (ID of the PaymentIntent)
        /// ID of the PaymentIntent that's disputed.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string PaymentIntentId
        {
            get => this.InternalPaymentIntent?.Id;
            set => this.InternalPaymentIntent = SetExpandableFieldId(value, this.InternalPaymentIntent);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the PaymentIntent that's disputed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentIntent PaymentIntent
        {
            get => this.InternalPaymentIntent?.ExpandedObject;
            set => this.InternalPaymentIntent = SetExpandableFieldObject(value, this.InternalPaymentIntent);
        }

        [JsonProperty("payment_intent")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentIntent>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentIntent>))]
#endif
        internal ExpandableField<PaymentIntent> InternalPaymentIntent { get; set; }
        #endregion

        [JsonProperty("payment_method_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_details")]
#endif
        public DisputePaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// Reason given by cardholder for dispute. Possible values are <c>bank_cannot_process</c>,
        /// <c>check_returned</c>, <c>credit_not_processed</c>, <c>customer_initiated</c>,
        /// <c>debit_not_authorized</c>, <c>duplicate</c>, <c>fraudulent</c>, <c>general</c>,
        /// <c>incorrect_account_details</c>, <c>insufficient_funds</c>, <c>noncompliant</c>,
        /// <c>product_not_received</c>, <c>product_unacceptable</c>, <c>subscription_canceled</c>,
        /// or <c>unrecognized</c>. Learn more about <a
        /// href="https://stripe.com/docs/disputes/categories">dispute reasons</a>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        [JsonProperty("smart_disputes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("smart_disputes")]
#endif
        public DisputeSmartDisputes SmartDisputes { get; set; }

        /// <summary>
        /// The current status of a dispute. Possible values include:<c>warning_needs_response</c>,
        /// <c>warning_under_review</c>, <c>warning_closed</c>, <c>needs_response</c>,
        /// <c>under_review</c>, <c>won</c>, <c>lost</c>, or <c>prevented</c>.
        /// One of: <c>lost</c>, <c>needs_response</c>, <c>prevented</c>, <c>under_review</c>,
        /// <c>warning_closed</c>, <c>warning_needs_response</c>, <c>warning_under_review</c>, or
        /// <c>won</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
