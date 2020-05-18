namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CreditNoteLineOptions : INestedOptions
    {
        /// <summary>
        /// The line item amount to credit. Only valid when <see cref="Type"/> is
        /// <c>invoice_line_item</c> and the referenced invoice line item does not have a quantity,
        /// only an amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The description of the credit note line item. Only valid when the <see cref="Type"/> is
        /// <c>custom_line_item</c>.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The invoice line item to credit. Only valid when the <see cref="Type"/> is
        /// <c>invoice_line_item</c>.
        /// </summary>
        [JsonProperty("invoice_line_item")]
        public string InvoiceLineItem { get; set; }

        /// <summary>
        /// The line item quantity to credit.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the credit note line item. Only valid when the
        /// <see cref="Type"/> is <c>custom_line_item</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// Type of the credit note line item, one of <c>custom_line_item</c> or
        /// <c>invoice_line_item</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The integer unit amount of the credit note line item. This will be multiplied by the
        /// quantity to get the full amount to credit for this line item. Only valid
        /// when <see cref="Type"/> is <c>custom_line_item</c>.
        /// </summary>
        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <see cref="UnitAmount"/>, but contains a decimal value with at most 12 decimal
        /// places.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
