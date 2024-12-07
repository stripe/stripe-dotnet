namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class InvoiceDiscountAmount : StripeEntity<InvoiceDiscountAmount>
    {
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        #region Expandable Discount

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string DiscountId
        {
            get => this.InternalDiscount?.Id;
            set => this.InternalDiscount = SetExpandableFieldId(value, this.InternalDiscount);
        }

        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Discount Discount
        {
            get => this.InternalDiscount?.ExpandedObject;
            set => this.InternalDiscount = SetExpandableFieldObject(value, this.InternalDiscount);
        }

        [JsonProperty("discount")]
        [JsonConverter(typeof(ExpandableFieldConverter<Discount>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Discount>))]
#endif
        internal ExpandableField<Discount> InternalDiscount { get; set; }
        #endregion
    }
}
