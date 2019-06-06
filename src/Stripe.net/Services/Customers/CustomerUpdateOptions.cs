namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CustomerUpdateOptions : BaseOptions
    {
        [Obsolete("Use Balance")]
        [JsonProperty("account_balance")]
        public long? AccountBalance { get; set; }

        /// <summary>
        /// The customer’s address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Current balance, if any, being stored on the customer. If negative, the customer has
        /// credit to apply to their next invoice. If positive, the customer has an amount owed that
        /// will be added to their next invoice. The balance does not refer to any unpaid invoices;
        /// it solely takes into account amounts that have yet to be successfully applied to any
        /// invoice. This balance is only taken into account as invoices are finalized.
        /// </summary>
        [JsonProperty("balance")]
        public long? Balance { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("invoice_settings")]
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The customer’s full name or business name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The customer’s phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The customer’s preferred locales (languages), ordered by preference.
        /// </summary>
        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        public string SourceToken { get; set; }

        [JsonProperty("source")]
        public CardCreateNestedOptions SourceCard { get; set; }

        /// <summary>
        /// Describes the customer’s tax exemption status. One of <c>none</c>,  <c>exempt</c>, or
        /// <c>reverse</c>.
        /// </summary>
        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        [Obsolete("Use TaxIdService.Create() instead")]
        [JsonProperty("tax_info")]
        public CustomerTaxInfoOptions TaxInfo { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
