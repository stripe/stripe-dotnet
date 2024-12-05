// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceShippingCostShippingRateDataDeliveryEstimateMinimumOptions : INestedOptions
    {
        /// <summary>
        /// A unit of time.
        /// One of: <c>business_day</c>, <c>day</c>, <c>hour</c>, <c>month</c>, or <c>week</c>.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Must be greater than 0.
        /// </summary>
        [JsonProperty("value")]
        public long? Value { get; set; }
    }
}
