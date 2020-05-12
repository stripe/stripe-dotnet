namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class LineItemTax : StripeEntity<LineItemTax>
    {
        /// <summary>
        /// Amount of tax for this line item.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable TaxRate

        /// <summary>
        /// ID of the tax rate applied to this line item.
        /// </summary>
        [JsonIgnore]
        public string TaxRateId
        {
            get => this.InternalTaxRate?.Id;
            set => this.InternalTaxRate = SetExpandableFieldId(value, this.InternalTaxRate);
        }

        /// <summary>
        /// (Expanded) The tax rate applied to this line item. (if it was expanded).
        /// </summary>
        [JsonIgnore]
        public TaxRate TaxRate
        {
            get => this.InternalTaxRate?.ExpandedObject;
            set => this.InternalTaxRate = SetExpandableFieldObject(value, this.InternalTaxRate);
        }

        [JsonProperty("tax_rate")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxRate>))]
        internal ExpandableField<TaxRate> InternalTaxRate { get; set; }
        #endregion
    }
}
