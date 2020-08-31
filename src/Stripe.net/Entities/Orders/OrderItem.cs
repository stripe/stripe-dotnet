namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderItem : StripeEntity<OrderItem>, IHasObject
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        #region Expandable Parent

        [JsonIgnore]
        public string ParentId
        {
            get => this.InternalParent?.Id;
            set => this.InternalParent = SetExpandableFieldId(value, this.InternalParent);
        }

        [JsonIgnore]
        public Sku Parent
        {
            get => this.InternalParent?.ExpandedObject;
            set => this.InternalParent = SetExpandableFieldObject(value, this.InternalParent);
        }

        [JsonProperty("parent")]
        [JsonConverter(typeof(ExpandableFieldConverter<Sku>))]
        internal ExpandableField<Sku> InternalParent { get; set; }
        #endregion

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
