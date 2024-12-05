// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemTaxAmountTaxRateDataOptions : INestedOptions
    {
        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// An arbitrary string attached to the tax rate for your internal use only. It will not be
        /// visible to your customers.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The display name of the tax rate, which will be shown to users.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// This specifies if the tax rate is inclusive or exclusive.
        /// </summary>
        [JsonProperty("inclusive")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inclusive")]
#endif
        public bool? Inclusive { get; set; }

        /// <summary>
        /// The jurisdiction for the tax rate. You can use this label field for tax reporting
        /// purposes. It also appears on your customer’s invoice.
        /// </summary>
        [JsonProperty("jurisdiction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jurisdiction")]
#endif
        public string Jurisdiction { get; set; }

        /// <summary>
        /// The statutory tax rate percent. This field accepts decimal values between 0 and 100
        /// inclusive with at most 4 decimal places. To accommodate fixed-amount taxes, set the
        /// percentage to zero. Stripe will not display zero percentages on the invoice unless the
        /// <c>amount</c> of the tax is also zero.
        /// </summary>
        [JsonProperty("percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("percentage")]
#endif
        public decimal? Percentage { get; set; }

        /// <summary>
        /// <a href="https://en.wikipedia.org/wiki/ISO_3166-2:US">ISO 3166-2 subdivision code</a>,
        /// without country prefix. For example, "NY" for New York, United States.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }

        /// <summary>
        /// The high-level tax type, such as <c>vat</c> or <c>sales_tax</c>.
        /// One of: <c>amusement_tax</c>, <c>communications_tax</c>, <c>gst</c>, <c>hst</c>,
        /// <c>igst</c>, <c>jct</c>, <c>lease_tax</c>, <c>pst</c>, <c>qst</c>,
        /// <c>retail_delivery_fee</c>, <c>rst</c>, <c>sales_tax</c>, <c>service_tax</c>, or
        /// <c>vat</c>.
        /// </summary>
        [JsonProperty("tax_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_type")]
#endif
        public string TaxType { get; set; }
    }
}
