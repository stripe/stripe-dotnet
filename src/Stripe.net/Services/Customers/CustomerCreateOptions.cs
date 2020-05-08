namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("address")]
        public CustomerAddressOptions Address { get; set; }

        [JsonProperty("balance")]
        public long? Balance { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

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

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("next_invoice_sequence")]
        public long? NextInvoiceSequence { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        [JsonProperty("shipping")]
        public CustomerShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        [JsonProperty("tax_id_data")]
        public List<CustomerTaxIdDatumOptions> TaxIdData { get; set; }
    }
}
