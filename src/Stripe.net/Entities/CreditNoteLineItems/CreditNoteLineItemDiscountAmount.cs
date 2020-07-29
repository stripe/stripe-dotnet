namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditNoteLineItemDiscountAmount : StripeEntity<CreditNoteLineItemDiscountAmount>
    {
        /// <summary>
        /// The amount, in cents, of the tax.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable Discount

        /// <summary>
        /// The ID of the discount that was applied to get this discount amount.
        /// </summary>
        [JsonIgnore]
        public string DiscountId
        {
            get => this.InternalDiscount?.Id;
            set => this.InternalDiscount = SetExpandableFieldId(value, this.InternalDiscount);
        }

        /// <summary>
        /// The discount that was applied to get this discount amount.
        /// </summary>
        [JsonIgnore]
        public Discount Discount
        {
            get => this.InternalDiscount?.ExpandedObject;
            set => this.InternalDiscount = SetExpandableFieldObject(value, this.InternalDiscount);
        }

        [JsonProperty("discount")]
        [JsonConverter(typeof(ExpandableFieldConverter<Discount>))]
        internal ExpandableField<Discount> InternalDiscount { get; set; }
        #endregion
    }
}
