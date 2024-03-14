// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class MeterDefaultAggregationOptions : INestedOptions
    {
        /// <summary>
        /// Specifies how events are aggregated. Allowed values are <c>count</c> to count the number
        /// of events, <c>sum</c> to sum each event's value, or <c>last</c> to use the last event's
        /// value.
        /// One of: <c>count</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("formula")]
        public string Formula { get; set; }
    }
}
