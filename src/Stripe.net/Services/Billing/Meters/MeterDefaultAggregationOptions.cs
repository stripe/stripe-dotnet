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
        /// Specifies how events are aggregated.
        /// One of: <c>count</c>, <c>last</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("formula")]
        [STJS.JsonPropertyName("formula")]
        public string Formula { get; set; }
    }
}
