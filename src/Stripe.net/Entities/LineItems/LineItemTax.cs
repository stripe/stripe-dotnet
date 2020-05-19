namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class LineItemTax : StripeEntity<LineItemTax>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        #region Expandable TaxRate

        [JsonIgnore]
        public string TaxRateId
        {
            get => this.InternalTaxRate?.Id;
            set => this.InternalTaxRate = SetExpandableFieldId(value, this.InternalTaxRate);
        }

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
