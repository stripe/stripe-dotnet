using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeRecipientTransfer : StripeEntityWithId
    {
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("amount_reversed")]
        public int AmountReversed { get; set; }

        #region Expandable Balance Transaction
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public StripeBalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                ExpandableProperty<StripeBalanceTransaction>.Map(value, s => BalanceTransactionId = s, o => BalanceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("bank_account")]
        public StripeBankAccount BankAccount { get; set; }

        [JsonProperty("card")]
        public StripeCard Card { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("date")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("failure_code")]
        public string FailureCode { get; set; }

        [JsonProperty("failure_message")]
        public string FailureMessage { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        #region Expandable Recipient

        public string RecipientId { get; set; }

        [JsonIgnore]
        public StripeRecipient Recipient { get; set; }

        [JsonProperty("recipient")]
        internal object InternalRecipient
        {
            set
            {
                ExpandableProperty<StripeRecipient>.Map(value, s => RecipientId = s, o => Recipient = o);
            }
        }
        #endregion

        [JsonProperty("reversals")]
        public StripeList<StripeTransferReversal> TransferReversals { get; set; }

        [JsonProperty("reversed")]
        public bool Reversed { get; set; }

        [JsonProperty("source_transaction")]
        public string SourceTransactionId { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
