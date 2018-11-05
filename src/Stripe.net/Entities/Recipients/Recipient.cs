namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Recipient : StripeEntity, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("active_account")]
        public RecipientActiveAccount ActiveAccount { get; set; }

        [JsonProperty("cards")]
        public StripeList<Card> CardList { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        #region Expandable Default Card
        public string StripeDefaultCardId { get; set; }

        [JsonIgnore]
        public Card StripeDefaultCard { get; set; }

        [JsonProperty("default_card")]
        internal object InternalDefaultCard
        {
            set
            {
                StringOrObject<Card>.Map(value, s => this.StripeDefaultCardId = s, o => this.StripeDefaultCard = o);
            }
        }
        #endregion

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

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
