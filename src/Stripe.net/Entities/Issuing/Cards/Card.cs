namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Card : StripeEntity<Card>, IHasId, IHasMetadata, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("cancellation_reason")]
        public string CancellationReason { get; set; }

        [JsonProperty("cardholder")]
        public Cardholder Cardholder { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        [JsonProperty("exp_month")]
        public long ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long ExpYear { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        #region Expandable ReplacedBy

        [JsonIgnore]
        public string ReplacedById
        {
            get => this.InternalReplacedBy?.Id;
            set => this.InternalReplacedBy = SetExpandableFieldId(value, this.InternalReplacedBy);
        }

        [JsonIgnore]
        public Card ReplacedBy
        {
            get => this.InternalReplacedBy?.ExpandedObject;
            set => this.InternalReplacedBy = SetExpandableFieldObject(value, this.InternalReplacedBy);
        }

        [JsonProperty("replaced_by")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalReplacedBy { get; set; }
        #endregion

        #region Expandable ReplacementFor

        [JsonIgnore]
        public string ReplacementForId
        {
            get => this.InternalReplacementFor?.Id;
            set => this.InternalReplacementFor = SetExpandableFieldId(value, this.InternalReplacementFor);
        }

        [JsonIgnore]
        public Card ReplacementFor
        {
            get => this.InternalReplacementFor?.ExpandedObject;
            set => this.InternalReplacementFor = SetExpandableFieldObject(value, this.InternalReplacementFor);
        }

        [JsonProperty("replacement_for")]
        [JsonConverter(typeof(ExpandableFieldConverter<Card>))]
        internal ExpandableField<Card> InternalReplacementFor { get; set; }
        #endregion

        [JsonProperty("replacement_reason")]
        public string ReplacementReason { get; set; }

        [JsonProperty("shipping")]
        public CardShipping Shipping { get; set; }

        [JsonProperty("spending_controls")]
        public CardSpendingControls SpendingControls { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
