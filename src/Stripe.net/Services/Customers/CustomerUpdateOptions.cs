// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerUpdateOptions : BaseOptions, IHasMetadata
    {
        private AddressOptions address;
        private string businessName;
        private string individualName;
        private Dictionary<string, string> metadata;
        private ShippingOptions shipping;
        private string taxExempt;

        /// <summary>
        /// The customer's address. Learn about <a
        /// href="https://docs.stripe.com/invoicing/taxes?dashboard-or-api=dashboard#set-up-customer">country-specific
        /// requirements for calculating tax</a>.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("address")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public AddressOptions Address
        {
            get => this.address;
            set
            {
                this.address = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// An integer amount in cents (or local equivalent) that represents the customer's current
        /// balance, which affect the customer's future invoices. A negative amount represents a
        /// credit that decreases the amount due on an invoice; a positive amount increases the
        /// amount due on an invoice.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public long? Balance { get; set; }

        /// <summary>
        /// The customer's business name. This may be up to <em>150 characters</em>.
        /// </summary>
        [JsonProperty("business_name", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("business_name")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string BusinessName
        {
            get => this.businessName;
            set
            {
                this.businessName = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Balance information and default balance settings for this customer.
        /// </summary>
        [JsonProperty("cash_balance")]
        [STJS.JsonPropertyName("cash_balance")]
        public CustomerCashBalanceOptions CashBalance { get; set; }

        /// <summary>
        /// If you are using payment methods created via the PaymentMethods API, see the <a
        /// href="https://docs.stripe.com/api/customers/update#update_customer-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// parameter.
        ///
        /// Provide the ID of a payment source already attached to this customer to make it this
        /// customer's default payment source.
        ///
        /// If you want to add a new payment source and make it the default, see the <a
        /// href="https://docs.stripe.com/api/customers/update#update_customer-source">source</a>
        /// property.
        /// </summary>
        [JsonProperty("default_source")]
        [STJS.JsonPropertyName("default_source")]
        public string DefaultSource { get; set; }

        /// <summary>
        /// An arbitrary string that you can attach to a customer object. It is displayed alongside
        /// the customer in the dashboard.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Customer's email address. It's displayed alongside the customer in your dashboard and
        /// can be useful for searching and tracking. This may be up to <em>512 characters</em>.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The customer's full name. This may be up to <em>150 characters</em>.
        /// </summary>
        [JsonProperty("individual_name", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("individual_name")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string IndividualName
        {
            get => this.individualName;
            set
            {
                this.individualName = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers. Must be 3–12
        /// uppercase letters or numbers.
        /// </summary>
        [JsonProperty("invoice_prefix")]
        [STJS.JsonPropertyName("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        /// <summary>
        /// Default invoice settings for this customer.
        /// </summary>
        [JsonProperty("invoice_settings")]
        [STJS.JsonPropertyName("invoice_settings")]
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The customer's full name or business name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The sequence to be used on the customer's next invoice. Defaults to 1.
        /// </summary>
        [JsonProperty("next_invoice_sequence")]
        [STJS.JsonPropertyName("next_invoice_sequence")]
        public long? NextInvoiceSequence { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Customer's preferred languages, ordered by preference.
        /// </summary>
        [JsonProperty("preferred_locales")]
        [STJS.JsonPropertyName("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonProperty("shipping", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("shipping")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public ShippingOptions Shipping
        {
            get => this.shipping;
            set
            {
                this.shipping = value;
                this.SetTracker.Track();
            }
        }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("source")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        /// <summary>
        /// Tax details about the customer.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public CustomerTaxOptions Tax { get; set; }

        /// <summary>
        /// The customer's tax exemption. One of <c>none</c>, <c>exempt</c>, or <c>reverse</c>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("tax_exempt")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public string TaxExempt
        {
            get => this.taxExempt;
            set
            {
                this.taxExempt = value;
                this.SetTracker.Track();
            }
        }

        [JsonProperty("validate")]
        [STJS.JsonPropertyName("validate")]
        public bool? Validate { get; set; }
    }
}
