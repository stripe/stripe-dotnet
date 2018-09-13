namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeRecipient : StripeEntityWithId, ISupportMetadata
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("active_account")]
        public StripeRecipientActiveAccount ActiveAccount { get; set; }

        [JsonProperty("cards")]
        public StripeList<StripeCard> StripeCardList { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        #region Expandable Default Card
        public string StripeDefaultCardId { get; set; }

        [JsonIgnore]
        public StripeCard StripeDefaultCard { get; set; }

        [JsonProperty("default_card")]
        internal object InternalDefaultCard
        {
            set
            {
                StringOrObject<StripeCard>.Map(value, s => this.StripeDefaultCardId = s, o => this.StripeDefaultCard = o);
            }
        }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("migrated_to")]
        public string MigratedTo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rolled_back_from")]
        public string RolledBackFrom { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}
