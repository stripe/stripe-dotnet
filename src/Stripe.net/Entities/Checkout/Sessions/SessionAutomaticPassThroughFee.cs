// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionAutomaticPassThroughFee : StripeEntity<SessionAutomaticPassThroughFee>
    {
        /// <summary>
        /// Whether the fee is calculated on the amount due before or after tax.
        /// One of: <c>total_after_tax</c>, or <c>total_before_tax</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("calculation_basis")]
        [STJS.JsonPropertyName("calculation_basis")]
        public string CalculationBasis { get; set; }

        /// <summary>
        /// Indicates whether a pass-through fee is calculated and added to this session.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The provider that performed this session's latest pass-through fee calculation.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The status of the most recent pass-through fee calculation for this session.
        /// One of: <c>complete</c>, <c>failed</c>, <c>not_applicable</c>, or <c>requires_input</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of fee calculated for this session.
        /// One of: <c>convenience_fee</c>, or <c>service_fee</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
