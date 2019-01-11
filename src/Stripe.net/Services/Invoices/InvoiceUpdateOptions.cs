namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceUpdateOptions : BaseOptions
    {
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }

        [JsonProperty("closed")]
        public bool? Closed { get; set; }

        /// <summary>
        /// A list of up to 4 custom fields to be displayed on the invoice.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<InvoiceCustomFieldOptions> CustomFields { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Footer to be displayed on the invoice. This can be unset by updating the value to null and then saving.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("forgiven")]
        public bool? Forgiven { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Boolean representing whether an invoice is paid or not. To mark invoice as paid, pass true. Only applies to invoices where billing=send_invoice.
        /// </summary>
        [JsonProperty("paid")]
        public bool? Paid { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("transfer_data")]
        public InvoiceTransferDataOptions TransferData { get; set; }
    }
}
