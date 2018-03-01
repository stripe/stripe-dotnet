using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeInvoiceCreateOptions : StripeBaseOptions, ISupportMetadata
    {
        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        /// <summary>
        /// One of <see cref="StripeBilling" />. When charging automatically, Stripe will attempt to pay this invoice using the default source attached to the customer. When sending an invoice, Stripe will email this invoice to the customer with payment instructions. Defaults to charge_automatically.
        /// </summary>
        [JsonProperty("billing")]
        public StripeBilling? Billing { get; set; }

        /// <summary>
        /// The number of days from which the invoice is created until it is due. Only valid for invoices where billing=send_invoice.
        /// </summary>
        [JsonProperty("days_until_due")]
        public int? DaysUntilDue { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The date on which payment for this invoice is due. Only valid for invoices where billing=send_invoice.
        /// </summary>
        public DateTime? DueDate { get; set; }

        [JsonProperty("due_date")]
        internal long? DueDateInternal => DueDate?.ConvertDateTimeToEpoch();

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }
    }
}