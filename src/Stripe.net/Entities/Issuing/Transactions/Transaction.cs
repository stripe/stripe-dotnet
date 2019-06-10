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
        public string AuthorizationId
        {
            get => this.InternalAuthorization.Id;
            set => this.InternalAuthorization.Id = value;
        }

        [JsonIgnore]
        public Authorization Authorization
        {
            get => this.InternalAuthorization.ExpandedObject;
            set => this.InternalAuthorization.ExpandedObject = value;
        }

        [JsonProperty("authorization")]
        [JsonConverter(typeof(ExpandableFieldConverter<Authorization>))]
        internal ExpandableField<Authorization> InternalAuthorization { get; set; }
        #endregion

        #region Expandable BalanceTransaction
        [JsonIgnore]
        public string BalanceTransactionId
        {
            get => this.InternalBalanceTransaction.Id;
            set => this.InternalBalanceTransaction.Id = value;
        }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction
        {
            get => this.InternalBalanceTransaction.ExpandedObject;
            set => this.InternalBalanceTransaction.ExpandedObject = value;
        }

        [JsonProperty("balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<BalanceTransaction>))]
        internal ExpandableField<BalanceTransaction> InternalBalanceTransaction { get; set; }
        #endregion

        #region Expandable Card
        [JsonIgnore]
        public string CardId
        {
            get => this.InternalCard.Id;
            set => this.InternalCard.Id = value;
        }

        [JsonIgnore]
        public Card Card
        {
            get => this.InternalCard.ExpandedObject;
            set => this.InternalCard.ExpandedObject = value;
        }

        [JsonProperty("card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalCard { get; set; }
        #endregion

        #region Expandable Cardholder
        [JsonIgnore]
        public string CardholderId
        {
            get => this.InternalCardholder.Id;
            set => this.InternalCardholder.Id = value;
        }

        [JsonIgnore]
        public Cardholder Cardholder
        {
            get => this.InternalCardholder.ExpandedObject;
            set => this.InternalCardholder.ExpandedObject = value;
        }

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
        public string DisputeId
        {
            get => this.InternalDispute.Id;
            set => this.InternalDispute.Id = value;
        }

        [JsonIgnore]
        public Dispute Dispute
        {
            get => this.InternalDispute.ExpandedObject;
            set => this.InternalDispute.ExpandedObject = value;
        }

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
