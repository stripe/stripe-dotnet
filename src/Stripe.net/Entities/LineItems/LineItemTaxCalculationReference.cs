// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class LineItemTaxCalculationReference : StripeEntity<LineItemTaxCalculationReference>
    {
        /// <summary>
        /// The calculation identifier for tax calculation response.
        /// </summary>
        [JsonProperty("calculation_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("calculation_id")]
#endif
        public string CalculationId { get; set; }

        /// <summary>
        /// The calculation identifier for tax calculation response line item.
        /// </summary>
        [JsonProperty("calculation_item_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("calculation_item_id")]
#endif
        public string CalculationItemId { get; set; }
    }
}
