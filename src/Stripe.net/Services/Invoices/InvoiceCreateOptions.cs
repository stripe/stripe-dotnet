namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("custom_fields")]
        public List<InvoiceCustomFieldOptions> CustomFields { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DueDate { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("transfer_data")]
        public InvoiceTransferDataOptions TransferData { get; set; }
    }
}
