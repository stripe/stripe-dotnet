namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Transfer : StripeEntity, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("amount_reversed")]
        public long AmountReversed { get; set; }

        #region Expandable Balance Transaction
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                StringOrObject<BalanceTransaction>.Map(value, s => this.BalanceTransactionId = s, o => this.BalanceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination
        public string DestinationId { get; set; }

        [JsonIgnore]
        public Account Destination { get; set; }

        [JsonProperty("destination")]
        internal object InternalDestination
        {
            set
            {
                StringOrObject<Account>.Map(value, s => this.DestinationId = s, o => this.Destination = o);
            }
        }
        #endregion

        #region Expandable Destination Payment
        public string DestinationPaymentId { get; set; }

        [JsonIgnore]
        public Charge DestinationPayment { get; set; }

        [JsonProperty("destination_payment")]
        internal object InternalDestinationPayment
        {
            set
            {
                StringOrObject<Charge>.Map(value, s => this.DestinationPaymentId = s, o => this.DestinationPayment = o);
            }
        }
        #endregion

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reversals")]
        public StripeList<TransferReversal> Reversals { get; set; }

        [JsonProperty("reversed")]
        public bool Reversed { get; set; }

        #region Expandable Source Transaction
        public string SourceTransactionId { get; set; }

        [JsonIgnore]
        public Charge SourceTransaction { get; set; }

        [JsonProperty("source_transaction")]
        internal object InternalSourceTransaction
        {
            set
            {
                StringOrObject<Charge>.Map(value, s => this.SourceTransactionId = s, o => this.SourceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
