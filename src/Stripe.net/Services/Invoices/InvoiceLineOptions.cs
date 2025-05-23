// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineOptions : INestedOptions, IHasMetadata, IHasId
    {
        /// <summary>
        /// The integer amount in cents (or local equivalent) of the charge to be applied to the
        /// upcoming invoice. If you want to apply a credit to the customer's account, pass a
        /// negative amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Either <c>delete</c> or <c>unassign</c>. Deleted line items are permanently deleted.
        /// Unassigned line items can be reassigned to an invoice.
        /// One of: <c>delete</c>, or <c>unassign</c>.
        /// </summary>
        [JsonProperty("behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("behavior")]
#endif
        public string Behavior { get; set; }

        /// <summary>
        /// An arbitrary string which you can attach to the invoice item. The description is
        /// displayed in the invoice for easy tracking.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// Controls whether discounts apply to this line item. Defaults to false for prorations or
        /// negative line items, and true for all other line items. Cannot be set to true for
        /// prorations.
        /// </summary>
        [JsonProperty("discountable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discountable")]
#endif
        public bool? Discountable { get; set; }

        /// <summary>
        /// The coupons, promotion codes &amp; existing discounts which apply to the line item. Item
        /// discounts are applied before invoice discounts. Pass an empty string to remove
        /// previously-defined discounts.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<InvoiceLineDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// ID of an existing line item to remove from this invoice.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// ID of an unassigned invoice item to assign to this invoice. If not provided, a new item
        /// will be created.
        /// </summary>
        [JsonProperty("invoice_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_item")]
#endif
        public string InvoiceItem { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>. For <a
        /// href="https://stripe.com/docs/api/invoices/line_item#invoice_line_item_object-type">type=subscription</a>
        /// line items, the incoming metadata specified on the request is directly used to set this
        /// value, in contrast to <a
        /// href="api/invoices/line_item#invoice_line_item_object-type">type=invoiceitem</a> line
        /// items, where any existing metadata on the invoice line is merged with the incoming data.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The period associated with this invoice item. When set to different values, the period
        /// will be rendered on the invoice. If you have <a
        /// href="https://stripe.com/docs/revenue-recognition">Stripe Revenue Recognition</a>
        /// enabled, the period will be used to recognize and defer revenue. See the <a
        /// href="https://stripe.com/docs/revenue-recognition/methodology/subscriptions-and-invoicing">Revenue
        /// Recognition documentation</a> for details.
        /// </summary>
        [JsonProperty("period")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("period")]
#endif
        public InvoiceLinePeriodOptions Period { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonProperty("price_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_data")]
#endif
        public InvoiceLinePriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The pricing information for the invoice item.
        /// </summary>
        [JsonProperty("pricing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing")]
#endif
        public InvoiceLinePricingOptions Pricing { get; set; }

        /// <summary>
        /// Non-negative integer. The quantity of units for the line item.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// A list of up to 10 tax amounts for this line item. This can be useful if you calculate
        /// taxes on your own or use a third-party to calculate them. You cannot set tax amounts if
        /// any line item has <a
        /// href="https://stripe.com/docs/api/invoices/line_item#invoice_line_item_object-tax_rates">tax_rates</a>
        /// or if the invoice has <a
        /// href="https://stripe.com/docs/api/invoices/object#invoice_object-default_tax_rates">default_tax_rates</a>
        /// or uses <a href="https://stripe.com/docs/tax/invoicing">automatic tax</a>. Pass an empty
        /// string to remove previously defined tax amounts.
        /// </summary>
        [JsonProperty("tax_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_amounts")]
#endif
        public List<InvoiceLineTaxAmountOptions> TaxAmounts { get; set; }

        /// <summary>
        /// The tax rates which apply to the line item. When set, the <c>default_tax_rates</c> on
        /// the invoice do not apply to this line item. Pass an empty string to remove
        /// previously-defined tax rates.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<string> TaxRates { get; set; }
    }
}
