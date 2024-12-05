// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionFlowAfterCompletion : StripeEntity<SessionFlowAfterCompletion>
    {
        /// <summary>
        /// Configuration when <c>after_completion.type=hosted_confirmation</c>.
        /// </summary>
        [JsonProperty("hosted_confirmation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_confirmation")]
#endif
        public SessionFlowAfterCompletionHostedConfirmation HostedConfirmation { get; set; }

        /// <summary>
        /// Configuration when <c>after_completion.type=redirect</c>.
        /// </summary>
        [JsonProperty("redirect")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect")]
#endif
        public SessionFlowAfterCompletionRedirect Redirect { get; set; }

        /// <summary>
        /// The specified type of behavior after the flow is completed.
        /// One of: <c>hosted_confirmation</c>, <c>portal_homepage</c>, or <c>redirect</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
