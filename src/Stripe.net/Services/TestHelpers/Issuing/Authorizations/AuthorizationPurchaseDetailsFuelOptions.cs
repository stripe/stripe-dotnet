// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationPurchaseDetailsFuelOptions : INestedOptions
    {
        /// <summary>
        /// <a href="https://www.conexxus.org/conexxus-payment-system-product-codes">Conexxus
        /// Payment System Product Code</a> identifying the primary fuel product purchased.
        /// </summary>
        [JsonProperty("industry_product_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("industry_product_code")]
#endif

        public string IndustryProductCode { get; set; }

        /// <summary>
        /// The quantity of <c>unit</c>s of fuel that was dispensed, represented as a decimal string
        /// with at most 12 decimal places.
        /// </summary>
        [JsonProperty("quantity_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity_decimal")]
#endif

        public decimal? QuantityDecimal { get; set; }

        /// <summary>
        /// The type of fuel that was purchased. One of <c>diesel</c>, <c>unleaded_plus</c>,
        /// <c>unleaded_regular</c>, <c>unleaded_super</c>, or <c>other</c>.
        /// One of: <c>diesel</c>, <c>other</c>, <c>unleaded_plus</c>, <c>unleaded_regular</c>, or
        /// <c>unleaded_super</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        /// <summary>
        /// The units for <c>quantity_decimal</c>. One of <c>charging_minute</c>,
        /// <c>imperial_gallon</c>, <c>kilogram</c>, <c>kilowatt_hour</c>, <c>liter</c>,
        /// <c>pound</c>, <c>us_gallon</c>, or <c>other</c>.
        /// One of: <c>charging_minute</c>, <c>imperial_gallon</c>, <c>kilogram</c>,
        /// <c>kilowatt_hour</c>, <c>liter</c>, <c>other</c>, <c>pound</c>, or <c>us_gallon</c>.
        /// </summary>
        [JsonProperty("unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit")]
#endif

        public string Unit { get; set; }

        /// <summary>
        /// The cost in cents per each unit of fuel, represented as a decimal string with at most 12
        /// decimal places.
        /// </summary>
        [JsonProperty("unit_cost_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_cost_decimal")]
#endif

        public decimal? UnitCostDecimal { get; set; }
    }
}
