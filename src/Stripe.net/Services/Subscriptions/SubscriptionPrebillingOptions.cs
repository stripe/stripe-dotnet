// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPrebillingOptions : INestedOptions
    {
        /// <summary>
        /// This is used to determine the number of billing cycles to prebill.
        /// </summary>
        [JsonProperty("iterations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iterations")]
#endif
        public long? Iterations { get; set; }

        /// <summary>
        /// Whether to cancel or preserve <c>prebilling</c> if the subscription is updated during
        /// the prebilled period. The default value is <c>reset</c>.
        /// One of: <c>prebill</c>, or <c>reset</c>.
        /// </summary>
        [JsonProperty("update_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("update_behavior")]
#endif
        public string UpdateBehavior { get; set; }
    }
}
