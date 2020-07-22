namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Topup : StripeEntity<Topup>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// A positive integer in the smallest currency unit (e.g., 100 cents to top up $1.00 or 100 to topup ¥100, a 0-decimal currency) representing how much to top up. The minimum amount is $0.50 US or equivalent in Top-up currency.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable BalanceTransaction

        /// <summary>
        /// ID of the balance transaction that describes the impact of this Top-up on your account balance (not including refunds or disputes).
        /// </summary>
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction?.Id;
            set => this.InternalBalanceTransaction = SetExpandableFieldId(value, this.InternalBalanceTransaction);
        }

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

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Three-letter ISO currency code representing the currency in which the Top-up was made.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expected_availability_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpectedAvailabilityDate { get; set; }

        /// <summary>
        /// Error code explaining reason for topup failure if available (see the errors section for a list of codes).
        /// </summary>
        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Message to user further explaining reason for topup failure if available.
        /// </summary>
        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a topup object. It can be useful for storing additional information about the topup in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// For most Stripe users, the source of every Top-up is a bank account. This hash is then the source object describing that bank account.
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }

        /// <summary>
        /// Extra information about a topup. This will appear on your customer's credit card statement.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The status of the top-up is either <c>canceled</c>, <c>failed</c>, <c>pending</c>,
        /// <c>reversed</c>, or <c>succeeded</c>.
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
