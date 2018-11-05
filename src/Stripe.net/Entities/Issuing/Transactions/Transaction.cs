namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Transaction : StripeEntity, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        #region Expandable Authorization
        public string AuthorizationId { get; set; }

        [JsonIgnore]
        public Authorization Authorization { get; set; }

        [JsonProperty("authorization")]
        internal object InternalAuthorization
        {
            set
            {
                StringOrObject<Authorization>.Map(value, s => this.AuthorizationId = s, o => this.Authorization = o);
            }
        }
        #endregion

        #region Expandable BalanceTransaction
        public string BalanceTransactionId { get; set; }

        [JsonIgnore]
        public BalanceTransaction BalanceTransaction { get; set; }

        [JsonProperty("balance_transaction")]
        internal object InternalBalanceTransaction
        {
            set
            {
                StringOrObject<BalanceTransaction>.Map(value, s => this.BalanceTransactionId = s, o => this.BalanceTransaction = o);
            }
        }
        #endregion

        #region Expandable Card
        public string CardId { get; set; }

        [JsonIgnore]
        public Card Card { get; set; }

        [JsonProperty("card")]
        internal object InternalCard
        {
            set
            {
                StringOrObject<Card>.Map(value, s => this.CardId = s, o => this.Card = o);
            }
        }
        #endregion

        #region Expandable Cardholder
        public string CardholderId { get; set; }

        [JsonIgnore]
        public Cardholder Cardholder { get; set; }

        [JsonProperty("cardholder")]
        internal object InternalCardholder
        {
            set
            {
                StringOrObject<Cardholder>.Map(value, s => this.CardholderId = s, o => this.Cardholder = o);
            }
        }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #region Expandable Dispute
        public string DisputeId { get; set; }

        [JsonIgnore]
        public Dispute Dispute { get; set; }

        [JsonProperty("dispute")]
        internal object InternalDispute
        {
            set
            {
                StringOrObject<Dispute>.Map(value, s => this.DisputeId = s, o => this.Dispute = o);
            }
        }
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
