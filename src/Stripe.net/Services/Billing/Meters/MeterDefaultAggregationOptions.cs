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
        /// of events and <c>sum</c> to sum each event's value.
        /// One of: <c>count</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("formula")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("formula")]
#endif

        public string Formula { get; set; }
    }
}
