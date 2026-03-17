// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceLineItemPriceDataProductDataTaxDetailsOptions : INestedOptions
    {
        /// <summary>
        /// A tax location ID. Depending on the <a
        /// href="https://stripe.com/tax/tax-for-tickets/reference/tax-location-performance">tax
        /// code</a>, this is required, optional, or not supported.
        /// </summary>
        [JsonProperty("performance_location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("performance_location")]
#endif
        public string PerformanceLocation { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }
    }
}
