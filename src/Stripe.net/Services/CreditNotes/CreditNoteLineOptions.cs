// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CreditNoteLineOptions : INestedOptions, IHasSetTracking
    {
        private List<CreditNoteLineTaxAmountOptions> taxAmounts;
        private List<string> taxRates;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The line item amount to credit. Only valid when <c>type</c> is <c>invoice_line_item</c>.
        /// If invoice is set up with <c>automatic_tax[enabled]=true</c>, this amount is tax
        /// exclusive.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The description of the credit note line item. Only valid when the <c>type</c> is
        /// <c>custom_line_item</c>.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The invoice line item to credit. Only valid when the <c>type</c> is
        /// <c>invoice_line_item</c>.
        /// </summary>
        [JsonProperty("invoice_line_item")]
        [STJS.JsonPropertyName("invoice_line_item")]
        public string InvoiceLineItem { get; set; }

        /// <summary>
        /// The line item quantity to credit.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// A list of up to 10 tax amounts for the credit note line item. Not valid when
        /// <c>tax_rates</c> is used or if invoice is set up with
        /// <c>automatic_tax[enabled]=true</c>.
        /// </summary>
        [JsonProperty("tax_amounts")]
        [STJS.JsonPropertyName("tax_amounts")]
        public List<CreditNoteLineTaxAmountOptions> TaxAmounts
        {
            get => this.taxAmounts;
            set
            {
                this.taxAmounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The tax rates which apply to the credit note line item. Only valid when the <c>type</c>
        /// is <c>custom_line_item</c> and <c>tax_amounts</c> is not used.
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

        /// <summary>
        /// Type of the credit note line item, one of <c>invoice_line_item</c> or
        /// <c>custom_line_item</c>. <c>custom_line_item</c> is not valid when the invoice is set up
        /// with <c>automatic_tax[enabled]=true</c>.
        /// One of: <c>custom_line_item</c>, or <c>invoice_line_item</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The integer unit amount in cents (or local equivalent) of the credit note line item.
        /// This <c>unit_amount</c> will be multiplied by the quantity to get the full amount to
        /// credit for this line item. Only valid when <c>type</c> is <c>custom_line_item</c>.
        /// </summary>
        [JsonProperty("unit_amount")]
        [STJS.JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value in cents (or local equivalent)
        /// with at most 12 decimal places. Only one of <c>unit_amount</c> and
        /// <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
