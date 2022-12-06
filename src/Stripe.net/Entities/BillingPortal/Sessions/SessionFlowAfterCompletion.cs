// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowAfterCompletion : StripeEntity<SessionFlowAfterCompletion>
    {
        /// <summary>
        /// Configuration when <c>after_completion.type=hosted_confirmation</c>.
        /// </summary>
        [JsonProperty("hosted_confirmation")]
        public SessionFlowAfterCompletionHostedConfirmation HostedConfirmation { get; set; }

        /// <summary>
        /// Configuration when <c>after_completion.type=redirect</c>.
        /// </summary>
        [JsonProperty("redirect")]
        public SessionFlowAfterCompletionRedirect Redirect { get; set; }

        /// <summary>
        /// The specified type of behavior after the flow is completed.
        /// One of: <c>hosted_confirmation</c>, <c>portal_homepage</c>, or <c>redirect</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
