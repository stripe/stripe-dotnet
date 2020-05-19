namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CreditNoteLineItem : StripeEntity<CreditNoteLineItem>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discount_amount")]
        public long DiscountAmount { get; set; }

        [JsonProperty("invoice_line_item")]
        public string InvoiceLineItem { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("tax_amounts")]
        public List<CreditNoteTaxAmount> TaxAmounts { get; set; }

        [JsonProperty("tax_rates")]
        public List<TaxRate> TaxRates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
