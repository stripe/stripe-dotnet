// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceLineItemUpdateOptions : BaseOptions, IHasMetadata
    {
        private List<InvoiceLineItemDiscountOptions> discounts;
        private List<string> margins;
        private Dictionary<string, string> metadata;
        private List<InvoiceLineItemTaxAmountOptions> taxAmounts;
        private List<string> taxRates;

        /// <summary>
        /// The integer amount in cents (or local equivalent) of the charge to be applied to the
        /// upcoming invoice. If you want to apply a credit to the customer's account, pass a
        /// negative amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to the invoice item. The description is
        /// displayed in the invoice for easy tracking.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Controls whether discounts apply to this line item. Defaults to false for prorations or
        /// negative line items, and true for all other line items. Cannot be set to true for
        /// prorations.
        /// </summary>
        [JsonProperty("discountable")]
        [STJS.JsonPropertyName("discountable")]
        public bool? Discountable { get; set; }

        /// <summary>
        /// The coupons, promotion codes &amp; existing discounts which apply to the line item. Item
        /// discounts are applied before invoice discounts. Pass an empty string to remove
        /// previously-defined discounts.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<InvoiceLineItemDiscountOptions> Discounts
        {
            get => this.discounts;
            set
            {
                this.discounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The IDs of the margins to apply to the line item. When set, the <c>default_margins</c>
        /// on the invoice do not apply to this line item.
        /// </summary>
        [JsonProperty("margins")]
        [STJS.JsonPropertyName("margins")]
        public List<string> Margins
        {
            get => this.margins;
            set
            {
                this.margins = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>. For <a
        /// href="https://stripe.com/api/invoices/line_item">type=subscription</a> line items, the
        /// incoming metadata specified on the request is directly used to set this value, in
        /// contrast to <a href="https://stripe.com/api/invoices/line_item">type=invoiceitem</a>
        /// line items, where any existing metadata on the invoice line is merged with the incoming
        /// data.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The period associated with this invoice item. When set to different values, the period
        /// will be rendered on the invoice. If you have <a
        /// href="https://docs.stripe.com/revenue-recognition">Stripe Revenue Recognition</a>
        /// enabled, the period will be used to recognize and defer revenue. See the <a
        /// href="https://docs.stripe.com/revenue-recognition/methodology/subscriptions-and-invoicing">Revenue
        /// Recognition documentation</a> for details.
        /// </summary>
        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public InvoiceLineItemPeriodOptions Period { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonProperty("price_data")]
        [STJS.JsonPropertyName("price_data")]
        public InvoiceLineItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The pricing information for the invoice item.
        /// </summary>
        [JsonProperty("pricing")]
        [STJS.JsonPropertyName("pricing")]
        public InvoiceLineItemPricingOptions Pricing { get; set; }

        /// <summary>
        /// Non-negative integer. The quantity of units for the line item. Use
        /// <c>quantity_decimal</c> instead to provide decimal precision. This field will be
        /// deprecated in favor of <c>quantity_decimal</c> in a future version.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Non-negative decimal with at most 12 decimal places. The quantity of units for the line
        /// item.
        /// </summary>
        [JsonProperty("quantity_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("quantity_decimal")]
        public decimal? QuantityDecimal { get; set; }

        /// <summary>
        /// A list of up to 10 tax amounts for this line item. This can be useful if you calculate
        /// taxes on your own or use a third-party to calculate them. You cannot set tax amounts if
        /// any line item has <a
        /// href="https://docs.stripe.com/api/invoices/line_item#invoice_line_item_object-tax_rates">tax_rates</a>
        /// or if the invoice has <a
        /// href="https://docs.stripe.com/api/invoices/object#invoice_object-default_tax_rates">default_tax_rates</a>
        /// or uses <a href="https://docs.stripe.com/tax/invoicing">automatic tax</a>. Pass an empty
        /// string to remove previously defined tax amounts.
        /// </summary>
        [JsonProperty("tax_amounts")]
        [STJS.JsonPropertyName("tax_amounts")]
        public List<InvoiceLineItemTaxAmountOptions> TaxAmounts
        {
            get => this.taxAmounts;
            set
            {
                this.taxAmounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The tax rates which apply to the line item. When set, the <c>default_tax_rates</c> on
        /// the invoice do not apply to this line item. Pass an empty string to remove
        /// previously-defined tax rates.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<string> TaxRates
        {
            get => this.taxRates;
            set
            {
                this.taxRates = value;
                this.SetTracker.Track();
            }
        }
    }
}
