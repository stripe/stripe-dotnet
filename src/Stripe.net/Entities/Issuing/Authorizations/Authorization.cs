namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Authorization : StripeEntity, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("authorization_method")]
        public string AuthorizationMethod { get; set; }

        [JsonProperty("authorized_amount")]
        public long AuthorizedAmount { get; set; }

        [JsonProperty("authorized_currency")]
        public string AuthorizedCurrency { get; set; }

        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }

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

        [JsonProperty("held_amount")]
        public long HeldAmount { get; set; }

        [JsonProperty("held_currency")]
        public string HeldCurrency { get; set; }

        [JsonProperty("is_held_amount_controllable")]
        public bool IsHeldAmountControllable { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("merchant_data")]
        public MerchantData MerchantData { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("pending_authorized_amount")]
        public long PendingAuthorizedAmount { get; set; }

        [JsonProperty("pending_held_amount")]
        public long PendingHeldAmount { get; set; }

        [JsonProperty("request_history")]
        public List<RequestHistory> RequestHistory { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        [JsonProperty("verification_data")]
        public VerificationData VerificationData { get; set; }
    }
}
