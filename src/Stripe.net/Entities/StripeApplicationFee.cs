using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeApplicationFee : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        #region Expandable Account
        public string AccountId { get; set; }

        [JsonIgnore]
        public StripeAccount Account { get; set; }

        [JsonProperty("account")]
        internal object InternalAccount
        {
            set
            {
                ExpandableProperty<StripeAccount>.Map(value, s => AccountId = s, o => Account = o);
            }
        }
        #endregion

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("application")]
        public string ApplicationId { get; set; }

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

        #region Expandable Card
        public string CardId { get; set; }

        [JsonIgnore]
        public StripeCard Card { get; set; }

        [JsonProperty("card")]
        internal object InternalCard
        {
            set
            {
                ExpandableProperty<StripeCard>.Map(value, s => CardId = s, o => Card = o);
            }
        }
        #endregion

        #region Expandable Charge
        public string ChargeId { get; set; }

        [JsonIgnore]
        public StripeCharge Charge { get; set; }

        [JsonProperty("charge")]
        internal object InternalCharge
        {
            set
            {
                ExpandableProperty<StripeCharge>.Map(value, s => ChargeId = s, o => Charge = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public StripeList<StripeApplicationFeeRefund> StripeApplicationFeeRefundList { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }
    }
}