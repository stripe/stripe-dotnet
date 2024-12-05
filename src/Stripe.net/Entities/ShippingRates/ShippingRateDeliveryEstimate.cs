// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ShippingRateDeliveryEstimate : StripeEntity<ShippingRateDeliveryEstimate>
    {
        /// <summary>
        /// The upper bound of the estimated range. If empty, represents no upper bound i.e.,
        /// infinite.
        /// </summary>
        [JsonProperty("maximum")]
        public ShippingRateDeliveryEstimateMaximum Maximum { get; set; }

        /// <summary>
        /// The lower bound of the estimated range. If empty, represents no lower bound.
        /// </summary>
        [JsonProperty("minimum")]
        public ShippingRateDeliveryEstimateMinimum Minimum { get; set; }
    }
}
