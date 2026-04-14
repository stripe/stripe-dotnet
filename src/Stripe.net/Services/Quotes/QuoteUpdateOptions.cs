// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteUpdateOptions : BaseOptions, IHasMetadata
    {
        private long? applicationFeeAmount;
        private decimal? applicationFeePercent;
        private List<string> defaultTaxRates;
        private string description;
        private List<QuoteDiscountOptions> discounts;
        private string footer;
        private string header;
        private string onBehalfOf;
        private QuoteTransferDataOptions transferData;

        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account. There cannot be any
        /// line items with recurring prices when using this field.
        /// </summary>
        [JsonProperty("application_fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("application_fee_amount")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public long? ApplicationFeeAmount
        {
            get => this.applicationFeeAmount;
            set
            {
                this.applicationFeeAmount = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. There must be at least 1 line item with a
        /// recurring price to use this field.
        /// </summary>
        [JsonProperty("application_fee_percent", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("application_fee_percent")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public decimal? ApplicationFeePercent
        {
            get => this.applicationFeePercent;
            set
            {
                this.applicationFeePercent = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Settings for automatic tax lookup for this quote and resulting invoices and
        /// subscriptions.
        /// </summary>
        [JsonProperty("automatic_tax")]
        [STJS.JsonPropertyName("automatic_tax")]
        public QuoteAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay invoices at the end of the subscription cycle or at invoice
        /// finalization using the default payment method attached to the subscription or customer.
        /// When sending an invoice, Stripe will email your customer an invoice with payment
        /// instructions and mark the subscription as <c>active</c>. Defaults to
        /// <c>charge_automatically</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        [STJS.JsonPropertyName("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// The customer for which this quote belongs to. A customer is required before finalizing
        /// the quote. Once specified, it cannot be changed.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The account for which this quote belongs to. A customer or account is required before
        /// finalizing the quote. Once specified, it cannot be changed.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }

        /// <summary>
        /// The tax rates that will apply to any line item that does not have <c>tax_rates</c> set.
        /// </summary>
        [JsonProperty("default_tax_rates", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("default_tax_rates")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> DefaultTaxRates
        {
            get => this.defaultTaxRates;
            set
            {
                this.defaultTaxRates = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A description that will be displayed on the quote PDF.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("description")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Description
        {
            get => this.description;
            set
            {
                this.description = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The discounts applied to the quote.
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("discounts")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<QuoteDiscountOptions> Discounts
        {
            get => this.discounts;
            set
            {
                this.discounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A future timestamp on which the quote will be canceled if in <c>open</c> or <c>draft</c>
        /// status. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A footer that will be displayed on the quote PDF.
        /// </summary>
        [JsonProperty("footer", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("footer")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Footer
        {
            get => this.footer;
            set
            {
                this.footer = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// A header that will be displayed on the quote PDF.
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("header")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string Header
        {
            get => this.header;
            set
            {
                this.header = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
        [STJS.JsonPropertyName("invoice_settings")]
        public QuoteInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// A list of line items the customer is being quoted for. Each line item includes
        /// information about the product, the quantity, and the resulting cost.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<QuoteLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The account on behalf of which to charge.
        /// </summary>
        [JsonProperty("on_behalf_of", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("on_behalf_of")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string OnBehalfOf
        {
            get => this.onBehalfOf;
            set
            {
                this.onBehalfOf = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// When creating a subscription or subscription schedule, the specified configuration data
        /// will be used. There must be at least one line item with a recurring price for a
        /// subscription or subscription schedule to be created. A subscription schedule is created
        /// if <c>subscription_data[effective_date]</c> is present and in the future, otherwise a
        /// subscription is created.
        /// </summary>
        [JsonProperty("subscription_data")]
        [STJS.JsonPropertyName("subscription_data")]
        public QuoteSubscriptionDataOptions SubscriptionData { get; set; }

        /// <summary>
        /// The data with which to automatically create a Transfer for each of the invoices.
        /// </summary>
        [JsonProperty("transfer_data", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("transfer_data")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public QuoteTransferDataOptions TransferData
        {
            get => this.transferData;
            set
            {
                this.transferData = value;
                this.SetTracker.Track();
            }
        }
    }
}
