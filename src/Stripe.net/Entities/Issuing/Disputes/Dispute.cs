namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Dispute : StripeEntity<Dispute>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        #region Expandable Transaction
        [JsonIgnore]
        public string TransactionId { get; set; }

        [JsonIgnore]
        public Transaction Transaction { get; set; }

        [JsonProperty("transaction")]
        internal object InternalTransaction
        {
            get
            {
                return this.Transaction ?? (object)this.TransactionId;
            }

            set
            {
                StringOrObject<Transaction>.Map(value, s => this.TransactionId = s, o => this.Transaction = o);
            }
        }
        #endregion
    }
}
