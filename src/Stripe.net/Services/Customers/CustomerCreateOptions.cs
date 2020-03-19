namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

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

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("preferred_locales")]
        public List<string> PreferredLocales { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        [JsonProperty("tax_exempt")]
        public string TaxExempt { get; set; }

        [JsonProperty("tax_id_data")]
        public List<CustomerTaxIdDataOptions> TaxIdData { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, SubscriptionTrialEnd> TrialEnd { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
