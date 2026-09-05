// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// To top up your Stripe balance, you create a top-up object. You can retrieve individual
    /// top-ups, as well as list all top-ups. Top-ups are identified by a unique, random ID.
    ///
    /// Related guide: <a href="https://docs.stripe.com/connect/top-ups">Topping up your
    /// platform account</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Topup : StripeEntity<Topup>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount transferred.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the balance transaction that describes the impact of this top-up on your account
        /// balance. May not be specified depending on status of top-up.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the balance transaction that describes the impact of this top-up on your account
        /// balance. May not be specified depending on status of top-up.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        [STJS.JsonPropertyName("balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Date the funds are expected to arrive in your Stripe account for payouts. This factors
        /// in delays like weekends or bank holidays. May not be specified depending on status of
        /// top-up.
        /// </summary>
        [JsonProperty("expected_availability_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expected_availability_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpectedAvailabilityDate { get; set; }

        /// <summary>
        /// Error code explaining reason for top-up failure if available (see <a
        /// href="https://stripe.com/api/errors">the errors section</a> for a list of codes).
        /// </summary>
        [JsonProperty("failure_code")]
        [STJS.JsonPropertyName("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Message to user further explaining reason for top-up failure if available.
        /// </summary>
        [JsonProperty("failure_message")]
        [STJS.JsonPropertyName("failure_message")]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Indicates whether the top-up was initiated by Stripe or by the user.
        /// One of: <c>stripe</c>, or <c>user</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("initiated_by")]
        [STJS.JsonPropertyName("initiated_by")]
        public string InitiatedBy { get; set; }

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

        #region Expandable PaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// The ID of a PaymentMethod representing the payment method used for the top-up. A
        /// PaymentMethod of type <c>us_bank_account</c> can be used.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of a PaymentMethod representing the payment method used for the top-up. A
        /// PaymentMethod of type <c>us_bank_account</c> can be used.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod?.ExpandedObject;
            set => this.InternalPaymentMethod = SetExpandableFieldObject(value, this.InternalPaymentMethod);
        }

        [JsonProperty("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        [STJS.JsonPropertyName("payment_method")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalPaymentMethod { get; set; }
        #endregion

        /// <summary>
        /// Payment-method-specific configuration for this top-up.
        /// </summary>
        [JsonProperty("payment_method_options")]
        [STJS.JsonPropertyName("payment_method_options")]
        public TopupPaymentMethodOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The source field is deprecated. It might not always be present in the API response.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public Source Source { get; set; }

        /// <summary>
        /// Extra information about a top-up. This will appear on your source's bank statement. It
        /// must contain at least one letter.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the top-up is either <c>canceled</c>, <c>failed</c>, <c>pending</c>,
        /// <c>reversed</c>, or <c>succeeded</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>pending</c>, <c>reversed</c>, or
        /// <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// A string that identifies this top-up as part of a group.
        /// </summary>
        [JsonProperty("transfer_group")]
        [STJS.JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
