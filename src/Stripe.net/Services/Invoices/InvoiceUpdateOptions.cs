namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A fee in %s that will be applied to the invoice and transferred to the application
        /// owner's Stripe account. The request must be made with an OAuth key or the Stripe-Account
        /// header in order to take an application fee. For more information, see the application
        /// fees <a href="https://stripe.com/docs/connect/subscriptions#invoices">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Controls whether Stripe will perform <a
        /// href="https://stripe.com/docs/billing/invoices/workflow/#auto_advance">automatic
        /// collection</a> of the invoice.
        /// </summary>
        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c> or <c>send_invoice</c>. This field can be updated
        /// only on <c>draft</c> invoices.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// A list of up to 4 custom fields to be displayed on the invoice. If a value for
        /// <c>custom_fields</c> is specified, the list specified will replace the existing custom
        /// field list on this invoice. Pass an empty string to remove previously-defined fields.
        /// </summary>
        [JsonProperty("custom_fields")]
        public List<InvoiceCustomFieldOptions> CustomFields { get; set; }

        /// <summary>
        /// The number of days from which the invoice is created until it is due. Only valid for
        /// invoices where <c>collection_method=send_invoice</c>. This field can only be updated on
        /// <c>draft</c> invoices.
        /// </summary>
        [JsonProperty("days_until_due")]
        public long? DaysUntilDue { get; set; }

        /// <summary>
        /// ID of the default payment method for the invoice. It must belong to the customer
        /// associated with the invoice. If not set, defaults to the subscription's default payment
        /// method, if any, or to the default payment method in the customer's invoice settings.
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// ID of the default payment source for the invoice. It must belong to the customer
        /// associated with the invoice and be in a chargeable state. If not set, defaults to the
        /// subscription's default source, if any, or to the customer's default source.
        /// </summary>
        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        /// <summary>
        /// The tax rates that will apply to any line item that does not have <c>tax_rates</c> set.
        /// Pass an empty string to remove previously-defined tax rates.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// Referenced as 'memo' in the Dashboard.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The discounts that will apply to the invoice. Pass an empty string to remove
        /// previously-defined discounts.
        /// </summary>
        [JsonProperty("discounts")]
        public List<InvoiceDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The date on which payment for this invoice is due. Only valid for invoices where
        /// <c>collection_method=send_invoice</c>. This field can only be updated on <c>draft</c>
        /// invoices.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Footer to be displayed on the invoice.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Extra information about a charge for the customer's credit card statement. It must
        /// contain at least one letter. If not specified and this invoice is part of a
        /// subscription, the default <c>statement_descriptor</c> will be set to the first
        /// subscription item's product's <c>statement_descriptor</c>.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// If specified, the funds from the invoice will be transferred to the destination and the
        /// ID of the resulting transfer will be found on the invoice's charge. This will be unset
        /// if you POST an empty value.
        /// </summary>
        [JsonProperty("transfer_data")]
        public InvoiceTransferDataOptions TransferData { get; set; }
    }
}
