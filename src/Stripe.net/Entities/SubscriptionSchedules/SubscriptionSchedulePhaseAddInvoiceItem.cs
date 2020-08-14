namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseAddInvoiceItem : StripeEntity<SubscriptionSchedulePhaseAddInvoiceItem>
    {
        #region Expandable Price

        [JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

        [JsonIgnore]
        public Price Price
        {
            get => this.InternalPrice?.ExpandedObject;
            set => this.InternalPrice = SetExpandableFieldObject(value, this.InternalPrice);
        }

        [JsonProperty("price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        internal ExpandableField<Price> InternalPrice { get; set; }
        #endregion

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}
