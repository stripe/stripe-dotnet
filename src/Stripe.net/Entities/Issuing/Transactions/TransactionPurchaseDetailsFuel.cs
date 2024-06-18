// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFuel : StripeEntity<TransactionPurchaseDetailsFuel>
    {
        /// <summary>
        /// The quantity of <c>unit</c>s of fuel that was dispensed, represented as a decimal string
        /// with at most 12 decimal places.
        /// </summary>
        [JsonProperty("quantity_decimal")]
        public decimal? QuantityDecimal { get; set; }

        /// <summary>
        /// The type of fuel that was purchased. One of <c>diesel</c>, <c>unleaded_plus</c>,
        /// <c>unleaded_regular</c>, <c>unleaded_super</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The units for <c>quantity_decimal</c>. One of <c>charging_minute</c>,
        /// <c>imperial_gallon</c>, <c>kilogram</c>, <c>kilowatt_hour</c>, <c>liter</c>,
        /// <c>pound</c>, <c>us_gallon</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The cost in cents per each unit of fuel, represented as a decimal string with at most 12
        /// decimal places.
        /// </summary>
        [JsonProperty("unit_cost_decimal")]
        public decimal UnitCostDecimal { get; set; }
    }
}
