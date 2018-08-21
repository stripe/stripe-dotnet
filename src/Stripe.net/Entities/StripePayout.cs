namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripePayout : StripeEntityWithId, ISupportMetadata
    {
        [JsonProperty("object")]
        public string Object => "payout";

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime ArrivalDate { get; set; }

        [JsonProperty("automatic")]
        public bool Automatic { get; set; }

        #region Expandable Balance Transaction
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public StripeBalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                StringOrObject<StripeBalanceTransaction>.Map(value, s => this.BalanceTransactionId = s, o => this.BalanceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Destination
        public string DestinationId { get; set; }

        [JsonIgnore]
        public ExternalAccount Destination { get; set; }

        [JsonProperty("destination")]
        internal object InternalDestination
        {
            set
            {
                StringOrObject<ExternalAccount>.Map(value, s => this.DestinationId = s, o => this.Destination = o);
            }
        }
        #endregion

        #region Expandable Cancellation Balance Transaction

        /// <summary>
        /// If the payout failed or was canceled, this will be the ID of the balance transaction that reversed the initial balance transaction, and puts the funds from the failed payout back in your balance.
        /// </summary>
        public string FailureBalanceTransactionId { get; set; }

        [JsonIgnore]
        public StripeBalanceTransaction FailureBalanceTransaction { get; set; }

        [JsonProperty("failure_balance_transaction")]
        internal object InternalFailureBalanceTransaction
        {
            set
            {
                StringOrObject<StripeBalanceTransaction>.Map(value, s => this.FailureBalanceTransactionId = s, o => this.FailureBalanceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        // example: bank_account
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
