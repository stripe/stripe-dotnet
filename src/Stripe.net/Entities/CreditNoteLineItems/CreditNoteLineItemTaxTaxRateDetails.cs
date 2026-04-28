// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CreditNoteLineItemTaxTaxRateDetails : StripeEntity<CreditNoteLineItemTaxTaxRateDetails>
    {
        #region Expandable TaxRate

        /// <summary>
        /// (ID of the TaxRate)
        /// ID of the tax rate.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string TaxRateId
        {
            get => this.InternalTaxRate?.Id;
            set => this.InternalTaxRate = SetExpandableFieldId(value, this.InternalTaxRate);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the tax rate.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public TaxRate TaxRate
        {
            get => this.InternalTaxRate?.ExpandedObject;
            set => this.InternalTaxRate = SetExpandableFieldObject(value, this.InternalTaxRate);
        }

        [JsonProperty("tax_rate")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxRate>))]
        [STJS.JsonPropertyName("tax_rate")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<TaxRate>))]
        internal ExpandableField<TaxRate> InternalTaxRate { get; set; }
        #endregion
    }
}
