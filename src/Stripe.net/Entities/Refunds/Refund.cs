namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Refund : StripeEntity, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

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

        #region Expandable Charge
        public string ChargeId { get; set; }

        [JsonIgnore]
        public Charge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            set
            {
                StringOrObject<Charge>.Map(value, s => this.ChargeId = s, o => this.Charge = o);
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

        #region Expandable Failure Balance Transaction
        public string FailureBalanceTransactionId { get; set; }

        [JsonIgnore]
        public BalanceTransaction FailureBalanceTransaction { get; set; }

        [JsonProperty("failure_balance_transaction")]
        internal object InternalFailureBalanceTransaction
        {
            set
            {
                StringOrObject<BalanceTransaction>.Map(value, s => this.FailureBalanceTransactionId = s, o => this.FailureBalanceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("failure_reason")]
        public string FailureReason { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
