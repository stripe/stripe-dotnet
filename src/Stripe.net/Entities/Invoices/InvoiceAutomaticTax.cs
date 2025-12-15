// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceAutomaticTax : StripeEntity<InvoiceAutomaticTax>
    {
        /// <summary>
        /// If Stripe disabled automatic tax, this enum describes why.
        /// One of: <c>finalization_requires_location_inputs</c>, or
        /// <c>finalization_system_error</c>.
        /// </summary>
        [JsonProperty("disabled_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disabled_reason")]
#endif
        public string DisabledReason { get; set; }

        /// <summary>
        /// Whether Stripe automatically computes tax on this invoice. Note that incompatible
        /// invoice items (invoice items with manually specified <a
        /// href="https://docs.stripe.com/api/tax_rates">tax rates</a>, negative amounts, or
        /// <c>tax_behavior=unspecified</c>) cannot be added to automatic tax invoices.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// The account that's liable for tax. If set, the business address and tax registrations
        /// required to perform the tax calculation are loaded from this account. The tax
        /// transaction is returned in the report of the connected account.
        /// </summary>
        [JsonProperty("liability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("liability")]
#endif
        public InvoiceAutomaticTaxLiability Liability { get; set; }

        /// <summary>
        /// The tax provider powering automatic tax.
        /// </summary>
        [JsonProperty("provider")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("provider")]
#endif
        public string Provider { get; set; }

        /// <summary>
        /// The status of the most recent automated tax calculation for this invoice.
        /// One of: <c>complete</c>, <c>failed</c>, or <c>requires_location_inputs</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
