// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. There cannot be any
        /// line items with recurring prices when using this field.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the application owner's Stripe account. There must be at least 1 line item with a
        /// recurring price to use this field.
        /// </summary>
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// Settings for automatic tax lookup for this quote and resulting invoices and
        /// subscriptions.
        /// </summary>
        [JsonProperty("automatic_tax")]
        public QuoteAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay invoices at the end of the subscription cycle or at invoice
        /// finalization using the default payment method attached to the subscription or customer.
        /// When sending an invoice, Stripe will email your customer an invoice with payment
        /// instructions. Defaults to <c>charge_automatically</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// The customer for which this quote belongs to. A customer is required before finalizing
        /// the quote. Once specified, it cannot be changed.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The tax rates that will apply to any line item that does not have <c>tax_rates</c> set.
        /// </summary>
        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// A description that will be displayed on the quote PDF. If no value is passed, the
        /// default description configured in your <a
        /// href="https://dashboard.stripe.com/settings/billing/quote">quote template settings</a>
        /// will be used.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The discounts applied to the quote. You can only set up to one discount.
        /// </summary>
        [JsonProperty("discounts")]
        public List<QuoteDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// A future timestamp on which the quote will be canceled if in <c>open</c> or <c>draft</c>
        /// status. Measured in seconds since the Unix epoch. If no value is passed, the default
        /// expiration date configured in your <a
        /// href="https://dashboard.stripe.com/settings/billing/quote">quote template settings</a>
        /// will be used.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A footer that will be displayed on the quote PDF. If no value is passed, the default
        /// footer configured in your <a
        /// href="https://dashboard.stripe.com/settings/billing/quote">quote template settings</a>
        /// will be used.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// Clone an existing quote. The new quote will be created in <c>status=draft</c>. When
        /// using this parameter, you cannot specify any other parameters except for
        /// <c>expires_at</c>.
        /// </summary>
        [JsonProperty("from_quote")]
        public QuoteFromQuoteOptions FromQuote { get; set; }

        /// <summary>
        /// A header that will be displayed on the quote PDF. If no value is passed, the default
        /// header configured in your <a
        /// href="https://dashboard.stripe.com/settings/billing/quote">quote template settings</a>
        /// will be used.
        /// </summary>
        [JsonProperty("header")]
        public string Header { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public QuoteInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// A list of line items the customer is being quoted for. Each line item includes
        /// information about the product, the quantity, and the resulting cost.
        /// </summary>
        [JsonProperty("line_items")]
        public List<QuoteLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The account on behalf of which to charge.
        /// </summary>
        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// When creating a subscription or subscription schedule, the specified configuration data
        /// will be used. There must be at least one line item with a recurring price for a
        /// subscription or subscription schedule to be created. A subscription schedule is created
        /// if <c>subscription_data[effective_date]</c> is present and in the future, otherwise a
        /// subscription is created.
        /// </summary>
        [JsonProperty("subscription_data")]
        public QuoteSubscriptionDataOptions SubscriptionData { get; set; }

        /// <summary>
        /// The data with which to automatically create a Transfer for each of the invoices.
        /// </summary>
        [JsonProperty("transfer_data")]
        public QuoteTransferDataOptions TransferData { get; set; }
    }
}
