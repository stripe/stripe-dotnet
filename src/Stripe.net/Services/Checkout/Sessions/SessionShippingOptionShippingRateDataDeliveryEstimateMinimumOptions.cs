// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionShippingOptionShippingRateDataDeliveryEstimateMinimumOptions : INestedOptions
    {
        /// <summary>
        /// A unit of time.
        /// One of: <c>business_day</c>, <c>day</c>, <c>hour</c>, <c>month</c>, or <c>week</c>.
        /// </summary>
        [JsonProperty("unit")]
        [STJS.JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Must be greater than 0.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public long? Value { get; set; }
    }
}
