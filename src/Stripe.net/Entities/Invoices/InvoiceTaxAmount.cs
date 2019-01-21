namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceTaxAmount : StripeEntity
    {
        /// <summary>
        /// The amount, in cents, of the tax.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// This specifies if the tax rate is inclusive or exclusive.
        /// </summary>
        [JsonProperty("inclusive")]
        public bool Inclusive { get; set; }

        #region Expandable TaxRate

        /// <summary>
        /// The ID of the tax rate that was applied to get this tax amount.
        /// </summary>
        [JsonIgnore]
        public string TaxRateId => this.InternalTaxRate.Id;

        [JsonIgnore]
        public TaxRate TaxRate => this.InternalTaxRate.ExpandedObject;

        [JsonProperty("tax_rate")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxRate>))]
        internal ExpandableField<TaxRate> InternalTaxRate { get; set; }
        #endregion
    }
}
