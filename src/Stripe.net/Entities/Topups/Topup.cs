namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Topup : StripeEntity<Topup>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount transferred.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// ID of the balance transaction that describes the impact of this top-up on your account
        /// balance. May not be specified depending on status of top-up.
        /// </summary>
        [JsonIgnore]
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
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
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

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Date the funds are expected to arrive in your Stripe account for payouts. This factors
        /// in delays like weekends or bank holidays. May not be specified depending on status of
        /// top-up.
        /// </summary>
        [JsonProperty("expected_availability_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpectedAvailabilityDate { get; set; }

        /// <summary>
        /// Error code explaining reason for top-up failure if available (see <a
        /// href="https://stripe.com/docs/api#errors">the errors section</a> for a list of codes).
        /// </summary>
        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Message to user further explaining reason for top-up failure if available.
        /// </summary>
        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

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
        /// <c>Source</c> objects allow you to accept a variety of payment methods. They represent a
        /// customer's payment instrument, and can be used with the Stripe API just like a
        /// <c>Card</c> object: once chargeable, they can be charged, or can be attached to
        /// customers.
        ///
        /// Related guides: <a href="https://stripe.com/docs/sources">Sources API</a> and <a
        /// href="https://stripe.com/docs/sources/customers">Sources &amp; Customers</a>.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// Extra information about a top-up. This will appear on your source's bank statement. It
        /// must contain at least one letter.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the top-up is either <c>canceled</c>, <c>failed</c>, <c>pending</c>,
        /// <c>reversed</c>, or <c>succeeded</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>pending</c>, <c>reversed</c>, or
        /// <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// A string that identifies this top-up as part of a group.
        /// </summary>
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
