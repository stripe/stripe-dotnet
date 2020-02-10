namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditNoteLineOptions : INestedOptions, IHasMetadata
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("invoice_line_item")]
        public string InvoiceLineItem { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
