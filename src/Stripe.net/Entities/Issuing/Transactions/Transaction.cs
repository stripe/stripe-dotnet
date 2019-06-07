namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Transaction : StripeEntity<Transaction>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Authorization
        [JsonIgnore]
        public string AuthorizationId => this.InternalAuthorization.Id;

        [JsonIgnore]
        public Authorization Authorization => this.InternalAuthorization.ExpandedObject;

        [JsonProperty("authorization")]
        [JsonConverter(typeof(ExpandableFieldConverter<Authorization>))]
        internal ExpandableField<Authorization> InternalAuthorization { get; set; }
        #endregion

        #region Expandable BalanceTransaction
        [JsonIgnore]
        public string BalanceTransactionId => this.InternalBalanceTransaction.Id;

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction => this.InternalBalanceTransaction.ExpandedObject;

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable Card
        [JsonIgnore]
        public string CardId => this.InternalCard.Id;

        [JsonIgnore]
        public Card Card => this.InternalCard.ExpandedObject;

        [JsonProperty("card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalCard { get; set; }
        #endregion

        #region Expandable Cardholder
        [JsonIgnore]
        public string CardholderId => this.InternalCardholder.Id;

        [JsonIgnore]
        public Cardholder Cardholder => this.InternalCardholder.ExpandedObject;

        [JsonProperty("cardholder")]
        [JsonConverter(typeof(ExpandableFieldConverter<Cardholder>))]
        internal ExpandableField<Cardholder> InternalCardholder { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Dispute
        [JsonIgnore]
        public string DisputeId => this.InternalDispute.Id;

        [JsonIgnore]
        public Dispute Dispute => this.InternalDispute.ExpandedObject;

        [JsonProperty("dispute")]
        [JsonConverter(typeof(ExpandableFieldConverter<Dispute>))]
        internal ExpandableField<Dispute> InternalDispute { get; set; }
        #endregion

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("merchant_data")]
        public MerchantData MerchantData { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
