using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Stripe
{
    public class StripeApplicationFee : StripeObject
    {
        [JsonProperty("livemode")]
        public bool? LiveMode { get; set; }

        public string AccountId { get; set; }

        /*
         * If the user is using the CamelCasePropertyNamesContractResolver and we don't tell the serializer to ignore this property,
         * the exception 'A member with the name 'account' already exists on 'Stripe.StripeApplicationFee'. Use the JsonPropertyAttribute to specify another name.'
         * will be thrown
         */
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

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("application")]
        public string ApplicationId { get; set; }

        public string BalanceTransactionId { get; set; }
        public StripeBalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                ExpandableProperty<StripeBalanceTransaction>.Map(value, s => BalanceTransactionId = s, o => BalanceTransaction = o);
            }
        }

        public string CardId { get; set; }

        /*
         * If the user is using the CamelCasePropertyNamesContractResolver and we don't tell the serializer to ignore this property,
         * the exception 'A member with the name 'charge' already exists on 'Stripe.StripeApplicationFee'. Use the JsonPropertyAttribute to specify another name.'
         * will be thrown
         */
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

        public string ChargeId { get; set; }

        /*
         * If the user is using the CamelCasePropertyNamesContractResolver and we don't tell the serializer to ignore this property,
         * the exception 'A member with the name 'charge' already exists on 'Stripe.StripeApplicationFee'. Use the JsonPropertyAttribute to specify another name.'
         * will be thrown
         */
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

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("refunded")]
        public bool Refunded { get; set; }

        [JsonProperty("refunds")]
        public List<StripeApplicationFeeRefund> Refunds { get; set; }

        [JsonProperty("amount_refunded")]
        public int AmountRefunded { get; set; }
    }
}