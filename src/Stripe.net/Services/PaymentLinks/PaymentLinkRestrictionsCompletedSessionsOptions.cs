// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkRestrictionsCompletedSessionsOptions : INestedOptions
    {
        /// <summary>
        /// The maximum number of checkout sessions that can be completed for the
        /// <c>completed_sessions</c> restriction to be met.
        /// </summary>
        [JsonProperty("limit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("limit")]
#endif
        public long? Limit { get; set; }
    }
}
