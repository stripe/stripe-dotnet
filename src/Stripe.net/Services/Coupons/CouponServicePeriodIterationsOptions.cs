// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CouponServicePeriodIterationsOptions : INestedOptions
    {
        /// <summary>
        /// The number of iterations the service period will repeat for. Only used when type is
        /// <c>count</c>, defaults to 1.
        /// </summary>
        [JsonProperty("count")]
        [STJS.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// The type of iterations, defaults to <c>count</c> if omitted.
        /// One of: <c>count</c>, or <c>forever</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
