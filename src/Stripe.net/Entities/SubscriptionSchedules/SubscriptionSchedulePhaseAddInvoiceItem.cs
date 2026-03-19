// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePhaseAddInvoiceItem : StripeEntity<SubscriptionSchedulePhaseAddInvoiceItem>, IHasMetadata
    {
        /// <summary>
        /// The stackable discounts that will be applied to the item.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<SubscriptionSchedulePhaseAddInvoiceItemDiscount> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public SubscriptionSchedulePhaseAddInvoiceItemPeriod Period { get; set; }

        #region Expandable Price

        /// <summary>
        /// (ID of the Price)
        /// ID of the price used to generate the invoice item.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PriceId
        {
            get => this.InternalPrice?.Id;
            set => this.InternalPrice = SetExpandableFieldId(value, this.InternalPrice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the price used to generate the invoice item.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public Price Price
        {
            get => this.InternalPrice?.ExpandedObject;
            set => this.InternalPrice = SetExpandableFieldObject(value, this.InternalPrice);
        }

        [JsonProperty("price")]
        [JsonConverter(typeof(ExpandableFieldConverter<Price>))]
        [STJS.JsonPropertyName("price")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Price>))]
        internal ExpandableField<Price> InternalPrice { get; set; }
        #endregion

        /// <summary>
        /// The quantity of the invoice item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the item. When set, the <c>default_tax_rates</c> do not
        /// apply to this item.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }
    }
}
