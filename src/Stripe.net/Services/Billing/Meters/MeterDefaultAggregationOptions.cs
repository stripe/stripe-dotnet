// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class MeterDefaultAggregationOptions : INestedOptions
    {
        /// <summary>
        /// Specifies how events are aggregated. Allowed values are <c>count</c> to count the number
        /// of events, <c>sum</c> to sum each event's value and <c>last</c> to take the last event's
        /// value in the window.
        /// One of: <c>count</c>, <c>last</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("formula")]
        [STJS.JsonPropertyName("formula")]
        public string Formula { get; set; }
    }
}
