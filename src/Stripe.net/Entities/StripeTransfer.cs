using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeTransfer : StripeEntityWithId, ISupportMetadata
    {
        [JsonProperty("object")]
        public string Object { get; set; }

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
                StringOrObject<StripeBalanceTransaction>.Map(value, s => BalanceTransactionId = s, o => BalanceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Destination
        public string DestinationId { get; set; }

        [JsonIgnore]
        public StripeAccount Destination { get; set; }

        [JsonProperty("destination")]
        internal object InternalDestination
        {
            set
            {
                StringOrObject<StripeAccount>.Map(value, s => DestinationId = s, o => Destination = o);
            }
        }
        #endregion

        #region Expandable Destination Payment
        public string DestinationPaymentId { get; set; }

        [JsonIgnore]
        public StripeCharge DestinationPayment { get; set; }

        [JsonProperty("destination_payment")]
        internal object InternalDestinationPayment
        {
            set
            {
                StringOrObject<StripeCharge>.Map(value, s => DestinationPaymentId = s, o => DestinationPayment = o);
            }
        }
        #endregion

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reversals")]
        public StripeList<StripeTransferReversal> Reversals { get; set; }

        [JsonProperty("reversed")]
        public bool Reversed { get; set; }

        #region Expandable Source Transaction
        public string SourceTransactionId { get; set; }

        [JsonIgnore]
        public StripeCharge SourceTransaction { get; set; }

        [JsonProperty("source_transaction")]
        internal object InternalSourceTransaction
        {
            set
            {
                StringOrObject<StripeCharge>.Map(value, s => SourceTransactionId = s, o => SourceTransaction = o);
            }
        }
        #endregion

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    } 
}