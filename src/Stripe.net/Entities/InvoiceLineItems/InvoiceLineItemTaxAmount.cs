// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceLineItemTaxAmount : StripeEntity<InvoiceLineItemTaxAmount>
    {
        /// <summary>
        /// The amount, in cents (or local equivalent), of the tax.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Whether this tax amount is inclusive or exclusive.
        /// </summary>
        [JsonProperty("inclusive")]
        public bool Inclusive { get; set; }

        #region Expandable TaxRate

        /// <summary>
        /// (ID of the TaxRate)
        /// The tax rate that was applied to get this tax amount.
        /// </summary>
        [JsonIgnore]
        public string TaxRateId
        {
            get => this.InternalTaxRate?.Id;
            set => this.InternalTaxRate = SetExpandableFieldId(value, this.InternalTaxRate);
        }

        /// <summary>
        /// (Expanded)
        /// The tax rate that was applied to get this tax amount.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
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

        /// <summary>
        /// The reasoning behind this tax, for example, if the product is tax exempt. The possible
        /// values for this field may be extended as new tax rules are supported.
        /// One of: <c>customer_exempt</c>, <c>not_collecting</c>, <c>not_subject_to_tax</c>,
        /// <c>not_supported</c>, <c>portion_product_exempt</c>, <c>portion_reduced_rated</c>,
        /// <c>portion_standard_rated</c>, <c>product_exempt</c>, <c>product_exempt_holiday</c>,
        /// <c>proportionally_rated</c>, <c>reduced_rated</c>, <c>reverse_charge</c>,
        /// <c>standard_rated</c>, <c>taxable_basis_reduced</c>, or <c>zero_rated</c>.
        /// </summary>
        [JsonProperty("taxability_reason")]
        public string TaxabilityReason { get; set; }

        /// <summary>
        /// The amount on which tax is calculated, in cents (or local equivalent).
        /// </summary>
        [JsonProperty("taxable_amount")]
        public long? TaxableAmount { get; set; }
    }
}
