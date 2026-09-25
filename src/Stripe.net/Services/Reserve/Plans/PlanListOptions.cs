// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PlanListOptions : ListOptions
    {
        /// <summary>
        /// Only return ReservePlans with the specified destination. If omitted, returns
        /// ReservePlans with any destination.
        /// One of: <c>risk_reserved</c>, or <c>settlement_reserved</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("destination")]
        [STJS.JsonPropertyName("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Only return ReservePlans with the specified status. If omitted, returns ReservePlans
        /// with any status.
        /// One of: <c>active</c>, <c>disabled</c>, or <c>expired</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
