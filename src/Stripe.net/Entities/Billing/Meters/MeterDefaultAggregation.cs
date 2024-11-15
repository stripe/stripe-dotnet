// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MeterDefaultAggregation : StripeEntity<MeterDefaultAggregation>
    {
        /// <summary>
        /// Specifies how events are aggregated.
        /// One of: <c>count</c>, or <c>sum</c>.
        /// </summary>
        [JsonProperty("formula")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("formula")]
#endif

        public string Formula { get; set; }
    }
}
