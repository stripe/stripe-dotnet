// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionBillForUnusedTimeFromOptions : INestedOptions
    {
        /// <summary>
        /// When to credit for unused time.
        /// One of: <c>item_current_period_start</c>, <c>none</c>, or <c>now</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
