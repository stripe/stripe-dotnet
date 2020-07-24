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
        public StripeList<Card> Cards { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; }

        #region Expandable DefaultCard

        [JsonIgnore]
        public string DefaultCardId
        {
            get => this.InternalDefaultCard?.Id;
            set => this.InternalDefaultCard = SetExpandableFieldId(value, this.InternalDefaultCard);
        }

        [JsonIgnore]
        public Card DefaultCard
        {
            get => this.InternalDefaultCard?.ExpandedObject;
            set => this.InternalDefaultCard = SetExpandableFieldObject(value, this.InternalDefaultCard);
        }

        [JsonProperty("default_card")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalDefaultCard { get; set; }
        #endregion

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        #region Expandable MigratedTo

        [JsonIgnore]
        public string MigratedToId
        {
            get => this.InternalMigratedTo?.Id;
            set => this.InternalMigratedTo = SetExpandableFieldId(value, this.InternalMigratedTo);
        }

        [JsonIgnore]
        public Account MigratedTo
        {
            get => this.InternalMigratedTo?.ExpandedObject;
            set => this.InternalMigratedTo = SetExpandableFieldObject(value, this.InternalMigratedTo);
        }

        [JsonProperty("migrated_to")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalMigratedTo { get; set; }
        #endregion

        [JsonProperty("name")]
        public string Name { get; set; }

        #region Expandable RolledBackFrom

        [JsonIgnore]
        public string RolledBackFromId
        {
            get => this.InternalRolledBackFrom?.Id;
            set => this.InternalRolledBackFrom = SetExpandableFieldId(value, this.InternalRolledBackFrom);
        }

        [JsonIgnore]
        public Account RolledBackFrom
        {
            get => this.InternalRolledBackFrom?.ExpandedObject;
            set => this.InternalRolledBackFrom = SetExpandableFieldObject(value, this.InternalRolledBackFrom);
        }

        [JsonProperty("rolled_back_from")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        internal ExpandableField<Account> InternalRolledBackFrom { get; set; }
        #endregion

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}
