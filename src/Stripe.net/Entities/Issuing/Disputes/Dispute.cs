namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Dispute : StripeEntity<Dispute>, IHasId, IHasObject
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
        /// List of balance transactions associated with this dispute.
        /// </summary>
        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Transaction

        /// <summary>
        /// (ID of the Transaction)
        /// The transaction being disputed.
        /// </summary>
        [JsonIgnore]
        public string TransactionId
        {
            get => this.InternalTransaction?.Id;
            set => this.InternalTransaction = SetExpandableFieldId(value, this.InternalTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// The transaction being disputed.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Transaction Transaction
        {
            get => this.InternalTransaction?.ExpandedObject;
            set => this.InternalTransaction = SetExpandableFieldObject(value, this.InternalTransaction);
        }

        [JsonProperty("transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<Transaction>))]
        internal ExpandableField<Transaction> InternalTransaction { get; set; }
        #endregion
    }
}
