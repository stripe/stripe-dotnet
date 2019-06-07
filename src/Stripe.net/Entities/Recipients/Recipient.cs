namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Recipient : StripeEntity<Recipient>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("active_account")]
        public BankAccount ActiveAccount { get; set; }

        [JsonProperty("cards")]
        public StripeList<Card> CardList { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        #region Expandable Default Card
        [JsonIgnore]
        public string DefaultCardId => this.InternalDefaultCard.Id;

        [JsonIgnore]
        public Card DefaultCard => this.InternalDefaultCard.ExpandedObject;

        [JsonProperty("default_card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalDefaultCard { get; set; }
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
