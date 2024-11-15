// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkRestrictionsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for the <c>completed_sessions</c> restriction type.
        /// </summary>
        [JsonProperty("completed_sessions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("completed_sessions")]
#endif

        public PaymentLinkRestrictionsCompletedSessionsOptions CompletedSessions { get; set; }
    }
}
