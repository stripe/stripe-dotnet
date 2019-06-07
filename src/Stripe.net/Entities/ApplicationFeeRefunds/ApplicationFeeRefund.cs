namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ApplicationFeeRefund : StripeEntity<ApplicationFeeRefund>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Balance Transaction
        [JsonIgnore]
        public string BalanceTransactionId => this.InternalBalanceTransaction.Id;

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction => this.InternalBalanceTransaction.ExpandedObject;

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Fee
        [JsonIgnore]
        public string FeeId => this.InternalFee.Id;

        [JsonIgnore]
        public ApplicationFee Fee => this.InternalFee.ExpandedObject;

        [JsonProperty("fee")]
        [JsonConverter(typeof(ExpandableFieldConverter<ApplicationFee>))]
        internal ExpandableField<ApplicationFee> InternalFee { get; set; }
        #endregion

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
