// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceLineItemPriceDataProductDataTaxDetailsOptions : INestedOptions
    {
        /// <summary>
        /// A tax location ID. Depending on the <a
        /// href="https://stripe.com/tax/tax-for-tickets/reference/tax-location-performance">tax
        /// code</a>, this is required, optional, or not supported.
        /// </summary>
        [JsonProperty("performance_location")]
        [STJS.JsonPropertyName("performance_location")]
        public string PerformanceLocation { get; set; }

        /// <summary>
        /// A <a href="https://docs.stripe.com/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
        [STJS.JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }
    }
}
