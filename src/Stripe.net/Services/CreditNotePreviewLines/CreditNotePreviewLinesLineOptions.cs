// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditNotePreviewLinesLineOptions : INestedOptions
    {
        /// <summary>
        /// The line item amount to credit. Only valid when <c>type</c> is <c>invoice_line_item</c>.
        /// If invoice is set up with <c>automatic_tax[enabled]=true</c>, this amount is tax
        /// exclusive.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The description of the credit note line item. Only valid when the <c>type</c> is
        /// <c>custom_line_item</c>.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The invoice line item to credit. Only valid when the <c>type</c> is
        /// <c>invoice_line_item</c>.
        /// </summary>
        [JsonProperty("invoice_line_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_line_item")]
#endif
        public string InvoiceLineItem { get; set; }

        /// <summary>
        /// The line item quantity to credit.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// A list of up to 10 tax amounts for the credit note line item. Not valid when
        /// <c>tax_rates</c> is used or if invoice is set up with
        /// <c>automatic_tax[enabled]=true</c>.
        /// </summary>
        [JsonProperty("tax_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_amounts")]
#endif
        public List<CreditNotePreviewLinesLineTaxAmountOptions> TaxAmounts { get; set; }

        /// <summary>
        /// The tax rates which apply to the credit note line item. Only valid when the <c>type</c>
        /// is <c>custom_line_item</c> and <c>tax_amounts</c> is not used.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// Type of the credit note line item, one of <c>invoice_line_item</c> or
        /// <c>custom_line_item</c>. <c>custom_line_item</c> is not valid when the invoice is set up
        /// with <c>automatic_tax[enabled]=true</c>.
        /// One of: <c>custom_line_item</c>, or <c>invoice_line_item</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The integer unit amount in cents (or local equivalent) of the credit note line item.
        /// This <c>unit_amount</c> will be multiplied by the quantity to get the full amount to
        /// credit for this line item. Only valid when <c>type</c> is <c>custom_line_item</c>.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value in cents (or local equivalent)
        /// with at most 12 decimal places. Only one of <c>unit_amount</c> and
        /// <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_decimal")]
#endif
        public decimal? UnitAmountDecimal { get; set; }
    }
}
