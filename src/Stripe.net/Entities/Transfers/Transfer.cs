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
    /// A <c>Transfer</c> object is created when you move funds between Stripe accounts as part
    /// of Connect.
    ///
    /// Before April 6, 2017, transfers also represented movement of funds from a Stripe account
    /// to a card or bank account. This behavior has since been split out into a <a
    /// href="https://api.stripe.com#payout_object">Payout</a> object, with corresponding payout
    /// endpoints. For more information, read about the <a
    /// href="https://docs.stripe.com/transfer-payout-split">transfer/payout split</a>.
    ///
    /// Related guide: <a
    /// href="https://docs.stripe.com/connect/separate-charges-and-transfers">Creating separate
    /// charges and transfers</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class Transfer : StripeEntity<Transfer>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
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
        /// Amount in cents (or local equivalent) to be transferred.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Amount in cents (or local equivalent) reversed (can be less than the amount attribute on
        /// the transfer if a partial reversal was issued).
        /// </summary>
        [JsonProperty("amount_reversed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_reversed")]
#endif
        public long AmountReversed { get; set; }

        #region Expandable ApplicationFee

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string ApplicationFeeId
        {
            get => this.InternalApplicationFee?.Id;
            set => this.InternalApplicationFee = SetExpandableFieldId(value, this.InternalApplicationFee);
        }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public ApplicationFee ApplicationFee
        {
            get => this.InternalApplicationFee?.ExpandedObject;
            set => this.InternalApplicationFee = SetExpandableFieldObject(value, this.InternalApplicationFee);
        }

        [JsonProperty("application_fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<ApplicationFee>))]
#endif
        internal ExpandableField<ApplicationFee> InternalApplicationFee { get; set; }
        #endregion

        [JsonProperty("application_fee_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_amount")]
#endif
        public long? ApplicationFeeAmount { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// (ID of the BalanceTransaction)
        /// Balance transaction that describes the impact of this transfer on your account balance.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// Balance transaction that describes the impact of this transfer on your account balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction?.ExpandedObject;
            set => this.InternalBalanceTransaction = SetExpandableFieldObject(value, this.InternalBalanceTransaction);
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<BalanceTransaction>))]
#endif
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// Time that this record of the transfer was first created.
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
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        #region Expandable Destination

        /// <summary>
        /// (ID of the Account)
        /// ID of the Stripe account the transfer was sent to.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DestinationId
        {
            get => this.InternalDestination?.Id;
            set => this.InternalDestination = SetExpandableFieldId(value, this.InternalDestination);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the Stripe account the transfer was sent to.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Account Destination
        {
            get => this.InternalDestination?.ExpandedObject;
            set => this.InternalDestination = SetExpandableFieldObject(value, this.InternalDestination);
        }

        [JsonProperty("destination")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Account>))]
#endif
        internal ExpandableField<Account> InternalDestination { get; set; }
        #endregion

        #region Expandable DestinationPayment

        /// <summary>
        /// (ID of the Charge)
        /// If the destination is a Stripe account, this will be the ID of the payment that the
        /// destination account received for the transfer.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DestinationPaymentId
        {
            get => this.InternalDestinationPayment?.Id;
            set => this.InternalDestinationPayment = SetExpandableFieldId(value, this.InternalDestinationPayment);
        }

        /// <summary>
        /// (Expanded)
        /// If the destination is a Stripe account, this will be the ID of the payment that the
        /// destination account received for the transfer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Charge DestinationPayment
        {
            get => this.InternalDestinationPayment?.ExpandedObject;
            set => this.InternalDestinationPayment = SetExpandableFieldObject(value, this.InternalDestinationPayment);
        }

        [JsonProperty("destination_payment")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif
        internal ExpandableField<Charge> InternalDestinationPayment { get; set; }
        #endregion

        /// <summary>
        /// The FX Quote used for the transfer.
        /// </summary>
        [JsonProperty("fx_quote")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fx_quote")]
#endif
        public string FxQuote { get; set; }

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
        /// A list of reversals that have been applied to the transfer.
        /// </summary>
        [JsonProperty("reversals")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reversals")]
#endif
        public StripeList<TransferReversal> Reversals { get; set; }

        /// <summary>
        /// Whether the transfer has been fully reversed. If the transfer is only partially
        /// reversed, this attribute will still be false.
        /// </summary>
        [JsonProperty("reversed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reversed")]
#endif
        public bool Reversed { get; set; }

        #region Expandable SourceTransaction

        /// <summary>
        /// (ID of the Charge)
        /// ID of the charge that was used to fund the transfer. If null, the transfer was funded
        /// from the available balance.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string SourceTransactionId
        {
            get => this.InternalSourceTransaction?.Id;
            set => this.InternalSourceTransaction = SetExpandableFieldId(value, this.InternalSourceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the charge that was used to fund the transfer. If null, the transfer was funded
        /// from the available balance.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Charge SourceTransaction
        {
            get => this.InternalSourceTransaction?.ExpandedObject;
            set => this.InternalSourceTransaction = SetExpandableFieldObject(value, this.InternalSourceTransaction);
        }

        [JsonProperty("source_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Charge>))]
#endif
        internal ExpandableField<Charge> InternalSourceTransaction { get; set; }
        #endregion

        /// <summary>
        /// The source balance this transfer came from. One of <c>card</c>, <c>fpx</c>, or
        /// <c>bank_account</c>.
        /// </summary>
        [JsonProperty("source_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_type")]
#endif
        public string SourceType { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. See the <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_group")]
#endif
        public string TransferGroup { get; set; }
    }
}
