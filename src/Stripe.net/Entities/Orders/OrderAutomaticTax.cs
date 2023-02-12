// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderAutomaticTax : StripeEntity<OrderAutomaticTax>
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on this Order.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The status of the most recent automated tax calculation for this Order.
        /// One of: <c>complete</c>, <c>failed</c>, or <c>requires_location_inputs</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
