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
        public string TaxRateId { get; set; }

        [JsonIgnore]
        public Account TaxRate { get; set; }

        [JsonProperty("tax_rate")]
        internal object InternalTaxRate
        {
            get
            {
                return this.TaxRate ?? (object)this.TaxRateId;
            }

            set
            {
                StringOrObject<Account>.Map(value, s => this.TaxRateId = s, o => this.TaxRate = o);
            }
        }
        #endregion
    }
}
