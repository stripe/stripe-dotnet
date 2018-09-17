namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceCreateOptions : BaseOptions, ISupportMetadata
    {
        /// <summary>
        /// A fee in cents that will be applied to the invoice and transferred to the application
        /// owner’s Stripe account. The request must be made with an OAuth key or the Stripe-Account
        /// header in order to take an application fee. For more information, see the application
        /// fees <see href="https://stripe.com/docs/connect/subscriptions#working-with-invoices">documentation</see>.
        /// </summary>
        [JsonProperty("application_fee")]
        public int? ApplicationFee { get; set; }

        /// <summary>
        /// One of <see cref="Billing" />. When charging automatically, Stripe will attempt to pay
        /// this invoice using the default source attached to the customer. When sending an invoice,
        /// Stripe will email this invoice to the customer with payment instructions. Defaults to
        /// <c>charge_automatically</c>.
        /// </summary>
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        /// <summary>
        /// REQUIRED
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// The number of days from which the invoice is created until it is due. Only valid for
        /// invoices where <c>billing=send_invoice</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
        public int? DaysUntilDue { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The date on which payment for this invoice is due. Only valid for invoices where
        /// <c>billing=send_invoice</c>.
        /// </summary>
        [JsonProperty("due_date")]
        public DateTime? DueDate { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Extra information about a charge for the customer’s credit card statement. It must
        /// contain at least one letter. If not specified and this invoice is part of a
        /// subscription, the default <c>statement_descriptor</c> will be set to the first
        /// subscription item’s product’s <c>statement_descriptor</c>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The ID of the subscription to invoice. If not set, the created invoice will include all
        /// pending invoice items for the customer. If set, the created invoice will exclude pending
        /// invoice items that pertain to other subscriptions.
        /// </summary>
        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The percent tax rate applied to the invoice, represented as a decimal number.
        /// </summary>
        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }
    }
}
