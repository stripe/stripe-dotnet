// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProductTaxDetails : StripeEntity<ProductTaxDetails>
    {
        /// <summary>
        /// The ID of a tax location with type <c>performance</c>, representing where the
        /// performance takes place.
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
