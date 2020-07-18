namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A fee in cents that will be applied to the invoice and transferred to the application
        /// owner’s Stripe account. The request must be made with an OAuth key or the Stripe-Account
        /// header in order to take an application fee. For more information, see the application
        /// fees <see href="https://stripe.com/docs/connect/subscriptions#working-with-invoices">documentation</see>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When
        /// charging automatically, Stripe will attempt to pay this invoice
        /// using the default source attached to the customer. When sending an
        /// invoice, Stripe will email this invoice to the customer with payment
        /// instructions. Defaults to <c>charge_automatically</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// A list of up to 4 custom fields to be displayed on the invoice.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<InvoiceCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// REQUIRED.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The number of days from which the invoice is created until it is due. Only valid for
        /// invoices where <c>billing=send_invoice</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        /// <summary>
        /// ID of the default payment method for the invoice.
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        /// <summary>
        /// Ids of the tax rates to apply to this subscription.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the invoice. If not specified, inherits the
        /// discount from the invoice's customer. Pass an empty string to avoid inheriting any
        /// discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<InvoiceDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The date on which payment for this invoice is due. Only valid for invoices where
        /// <c>billing=send_invoice</c>.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Footer to be displayed on the invoice. This can be unset by updating the value to null and then saving.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

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
        public string Subscription { get; set; }

        /// <summary>
        /// The percent tax rate applied to the invoice, represented as a decimal number.
        /// </summary>
        [Obsolete("Use DefaultTaxRates")]
        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("transfer_data")]
        public InvoiceTransferDataOptions TransferData { get; set; }
    }
}
