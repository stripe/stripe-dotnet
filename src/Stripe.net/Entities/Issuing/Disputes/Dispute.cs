namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Dispute : StripeEntity<Dispute>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        #region Expandable Transaction

        [JsonIgnore]
        public string TransactionId
        {
            get => this.InternalTransaction?.Id;
            set => this.InternalTransaction = SetExpandableFieldId(value, this.InternalTransaction);
        }

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
