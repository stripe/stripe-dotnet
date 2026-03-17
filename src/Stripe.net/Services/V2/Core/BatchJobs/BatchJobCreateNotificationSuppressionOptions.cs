// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BatchJobCreateNotificationSuppressionOptions : INestedOptions
    {
        /// <summary>
        /// The scope of notification suppression.
        /// One of: <c>all</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("scope")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scope")]
#endif
        public string Scope { get; set; }
    }
}
