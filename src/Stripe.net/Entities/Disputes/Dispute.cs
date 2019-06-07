namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Dispute : StripeEntity<Dispute>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        #region Expandable Charge
        [JsonIgnore]
        public string ChargeId => this.InternalCharge.Id;

        [JsonIgnore]
        public Charge Charge => this.InternalCharge.ExpandedObject;

        [JsonProperty("charge")]
        [JsonConverter(typeof(ExpandableFieldConverter<Charge>))]
        internal ExpandableField<Charge> InternalCharge { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("evidence")]
        public Evidence Evidence { get; set; }

        [JsonProperty("evidence_details")]
        public EvidenceDetails EvidenceDetails { get; set; }

        [JsonProperty("is_charge_refundable")]
        public bool IsChargeRefundable { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
