// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The account tax IDs associated with the invoice. Only editable when the invoice is a
        /// draft.
        /// </summary>
        [JsonProperty("account_tax_ids")]
        public List<string> AccountTaxIds { get; set; }

        /// <summary>
        /// A fee in cents (or local equivalent) that will be applied to the invoice and transferred
        /// to the application owner's Stripe account. The request must be made with an OAuth key or
        /// the Stripe-Account header in order to take an application fee. For more information, see
        /// the application fees <a
        /// href="https://stripe.com/docs/billing/invoices/connect#collecting-fees">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// Controls whether Stripe performs <a
        /// href="https://stripe.com/docs/invoicing/integration/automatic-advancement-collection">automatic
        /// collection</a> of the invoice.
        /// </summary>
        [JsonProperty("auto_advance")]
        public bool? AutoAdvance { get; set; }

        /// <summary>
        /// Settings for automatic tax lookup for this invoice.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public InvoiceAutomaticTaxOptions AutomaticTax { get; set; }

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
        /// The date when this invoice is in effect. Same as <c>finalized_at</c> unless overwritten.
        /// When defined, this value replaces the system-generated 'Date of issue' printed on the
        /// invoice PDF and receipt.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// Footer to be displayed on the invoice.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
        public InvoiceIssuerOptions Issuer { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Set the number for this invoice. If no number is present then a number will be assigned
        /// automatically when the invoice is finalized. In many markets, regulations require
        /// invoices to be unique, sequential and / or gapless. You are responsible for ensuring
        /// this is true across all your different invoicing systems in the event that you edit the
        /// invoice number using our API. If you use only Stripe for your invoices and do not change
        /// invoice numbers, Stripe handles this aspect of compliance for you automatically.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// The account (if any) for which the funds of the invoice payment are intended. If set,
        /// the invoice will be presented with the branding and support information of the specified
        /// account. See the <a href="https://stripe.com/docs/billing/invoices/connect">Invoices
        /// with Connect</a> documentation for details.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Configuration settings for the PaymentIntent that is generated when the invoice is
        /// finalized.
        /// </summary>
        [JsonProperty("payment_settings")]
        public InvoicePaymentSettingsOptions PaymentSettings { get; set; }

        /// <summary>
        /// The rendering-related settings that control how the invoice is displayed on
        /// customer-facing surfaces such as PDF and Hosted Invoice Page.
        /// </summary>
        [JsonProperty("rendering")]
        public InvoiceRenderingOptionsOptions Rendering { get; set; }

        /// <summary>
        /// This is a legacy field that will be removed soon. For details about
        /// <c>rendering_options</c>, refer to <c>rendering</c> instead. Options for invoice PDF
        /// rendering.
        /// </summary>
        [JsonProperty("rendering_options")]
        public InvoiceRenderingOptionsOptions RenderingOptions { get; set; }

        /// <summary>
        /// Settings for the cost of shipping for this invoice.
        /// </summary>
        [JsonProperty("shipping_cost")]
        public InvoiceShippingCostOptions ShippingCost { get; set; }

        /// <summary>
        /// Shipping details for the invoice. The Invoice PDF will use the <c>shipping_details</c>
        /// value if it is set, otherwise the PDF will render the shipping address from the
        /// customer.
        /// </summary>
        [JsonProperty("shipping_details")]
        public InvoiceShippingDetailsOptions ShippingDetails { get; set; }

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
