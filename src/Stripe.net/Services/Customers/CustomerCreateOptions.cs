// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The customer's address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// An integer amount in cents (or local equivalent) that represents the customer's current
        /// balance, which affect the customer's future invoices. A negative amount represents a
        /// credit that decreases the amount due on an invoice; a positive amount increases the
        /// amount due on an invoice.
        /// </summary>
        [JsonProperty("balance")]
        public long? Balance { get; set; }

        /// <summary>
        /// Balance information and default balance settings for this customer.
        /// </summary>
        [JsonProperty("cash_balance")]
        public CustomerCashBalanceOptions CashBalance { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// An arbitrary string that you can attach to a customer object. It is displayed alongside
        /// the customer in the dashboard.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Customer's email address. It's displayed alongside the customer in your dashboard and
        /// can be useful for searching and tracking. This may be up to <em>512 characters</em>.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The prefix for the customer used to generate unique invoice numbers. Must be 3–12
        /// uppercase letters or numbers.
        /// </summary>
        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        /// <summary>
        /// Default invoice settings for this customer.
        /// </summary>
        [JsonProperty("invoice_settings")]
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The customer's full name or business name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The sequence to be used on the customer's next invoice. Defaults to 1.
        /// </summary>
        [JsonProperty("next_invoice_sequence")]
        public long? NextInvoiceSequence { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// Customer's preferred languages, ordered by preference.
        /// </summary>
        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        /// <summary>
        /// The API ID of a promotion code to apply to the customer. The customer will have a
        /// discount applied on all recurring payments. Charges you create through the API will not
        /// have the discount.
        /// </summary>
        [JsonProperty("promotion_code")]
        public string PromotionCode { get; set; }

        /// <summary>
        /// The customer's shipping information. Appears on invoices emailed to this customer.
        /// </summary>
        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        /// <summary>
        /// Tax details about the customer.
        /// </summary>
        [JsonProperty("tax")]
        public CustomerTaxOptions Tax { get; set; }

        /// <summary>
        /// The customer's tax exemption. One of <c>none</c>, <c>exempt</c>, or <c>reverse</c>.
        /// One of: <c>exempt</c>, <c>none</c>, or <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        /// <summary>
        /// The customer's tax IDs.
        /// </summary>
        [JsonProperty("tax_id_data")]
        public List<CustomerTaxIdDataOptions> TaxIdData { get; set; }

        /// <summary>
        /// ID of the test clock to attach to the customer.
        /// </summary>
        [JsonProperty("test_clock")]
        public string TestClock { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
