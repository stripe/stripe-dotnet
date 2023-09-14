// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationPurchaseDetailsFuelOptions : INestedOptions
    {
        /// <summary>
        /// The type of fuel that was purchased. One of <c>diesel</c>, <c>unleaded_plus</c>,
        /// <c>unleaded_regular</c>, <c>unleaded_super</c>, or <c>other</c>.
        /// One of: <c>diesel</c>, <c>other</c>, <c>unleaded_plus</c>, <c>unleaded_regular</c>, or
        /// <c>unleaded_super</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The units for <c>volume_decimal</c>. One of <c>us_gallon</c> or <c>liter</c>.
        /// One of: <c>liter</c>, or <c>us_gallon</c>.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The cost in cents per each unit of fuel, represented as a decimal string with at most 12
        /// decimal places.
        /// </summary>
        [JsonProperty("unit_cost_decimal")]
        public decimal? UnitCostDecimal { get; set; }

        /// <summary>
        /// The volume of the fuel that was pumped, represented as a decimal string with at most 12
        /// decimal places.
        /// </summary>
        [JsonProperty("volume_decimal")]
        public decimal? VolumeDecimal { get; set; }
    }
}
