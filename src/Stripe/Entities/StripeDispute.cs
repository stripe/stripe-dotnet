using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Stripe
{
    public class StripeDispute
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("livemode")]
        public bool? LiveMode { get; set; }

        [JsonProperty("amount")]
        public int? Amount { get; set; }

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

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        // evidence details

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        // this needs to be a BalanceTransactions array
        //public string BalanceTransactionId { get; set; }
        //public StripeBalanceTransaction BalanceTransaction { get; set; }

        //[JsonProperty("balance_transaction")]
        //internal object InternalBalanceTransaction
        //{
        //    set
        //    {
        //        ExpandableProperty<StripeBalanceTransaction>.Map(value, s => BalanceTransactionId = s, o => BalanceTransaction = o);
        //    }
        //}

        [JsonProperty("evidence")]
        public string Evidence { get; set; }

        [JsonProperty("evidence_due_by")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? EvidenceDueBy { get; set; }

        [JsonProperty("is_charge_refundable")]
        public bool IsChargeRefundable { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}