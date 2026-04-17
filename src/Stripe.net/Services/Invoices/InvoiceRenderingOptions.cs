// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceRenderingOptions : INestedOptions, IHasSetTracking
    {
        private string amountTaxDisplay;
        private long? templateVersion;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// How line-item prices and amounts will be displayed with respect to tax on invoice PDFs.
        /// One of <c>exclude_tax</c> or <c>include_inclusive_tax</c>. <c>include_inclusive_tax</c>
        /// will include inclusive tax (and exclude exclusive tax) in invoice PDF amounts.
        /// <c>exclude_tax</c> will exclude all tax (inclusive and exclusive alike) from invoice PDF
        /// amounts.
        /// One of: <c>exclude_tax</c>, or <c>include_inclusive_tax</c>.
        /// </summary>
        [JsonProperty("amount_tax_display", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("amount_tax_display")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string AmountTaxDisplay
        {
            get => this.amountTaxDisplay;
            set
            {
                this.amountTaxDisplay = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Invoice pdf rendering options.
        /// </summary>
        [JsonProperty("pdf")]
        [STJS.JsonPropertyName("pdf")]
        public InvoiceRenderingPdfOptions Pdf { get; set; }

        /// <summary>
        /// ID of the invoice rendering template to use for this invoice.
        /// </summary>
        [JsonProperty("template")]
        [STJS.JsonPropertyName("template")]
        public string Template { get; set; }

        /// <summary>
        /// The specific version of invoice rendering template to use for this invoice.
        /// </summary>
        [JsonProperty("template_version", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("template_version")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public long? TemplateVersion
        {
            get => this.templateVersion;
            set
            {
                this.templateVersion = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
