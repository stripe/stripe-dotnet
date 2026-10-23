// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionAutomaticPassThroughFeeOptions : INestedOptions
    {
        /// <summary>
        /// Whether the fee is calculated on the amount due before or after tax. Required when
        /// <c>enabled</c> is <c>true</c>.
        /// One of: <c>total_after_tax</c>, or <c>total_before_tax</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("calculation_basis")]
        [STJS.JsonPropertyName("calculation_basis")]
        public string CalculationBasis { get; set; }

        /// <summary>
        /// Set to <c>true</c> to calculate a pass-through fee using the customer's payment method
        /// details and location.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The type of fee to calculate. Required when <c>enabled</c> is <c>true</c>.
        /// One of: <c>convenience_fee</c>, or <c>service_fee</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
