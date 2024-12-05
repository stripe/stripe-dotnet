// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionShippingOptionShippingRateDataDeliveryEstimateOptions : INestedOptions
    {
        /// <summary>
        /// The upper bound of the estimated range. If empty, represents no upper bound i.e.,
        /// infinite.
        /// </summary>
        [JsonProperty("maximum")]
        public SessionShippingOptionShippingRateDataDeliveryEstimateMaximumOptions Maximum { get; set; }

        /// <summary>
        /// The lower bound of the estimated range. If empty, represents no lower bound.
        /// </summary>
        [JsonProperty("minimum")]
        public SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions Minimum { get; set; }
    }
}
