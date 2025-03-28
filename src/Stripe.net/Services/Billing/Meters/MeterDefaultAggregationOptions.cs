// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterDefaultAggregationOptions : INestedOptions
    {
        /// <summary>
        /// Specifies how events are aggregated. Allowed values are <c>count</c> to count the number
        /// of events, <c>sum</c> to sum each event's value and <c>last</c> to take the last event's
        /// value in the window.
        /// One of: <c>count</c>, <c>last</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("formula")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("formula")]
#endif
        public string Formula { get; set; }
    }
}
