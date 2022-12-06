// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowDataAfterCompletionOptions : INestedOptions
    {
        /// <summary>
        /// Configuration when <c>after_completion.type=hosted_confirmation</c>.
        /// </summary>
        [JsonProperty("hosted_confirmation")]
        public SessionFlowDataAfterCompletionHostedConfirmationOptions HostedConfirmation { get; set; }

        /// <summary>
        /// Configuration when <c>after_completion.type=redirect</c>.
        /// </summary>
        [JsonProperty("redirect")]
        public SessionFlowDataAfterCompletionRedirectOptions Redirect { get; set; }

        /// <summary>
        /// The specified behavior after the flow is completed.
        /// One of: <c>hosted_confirmation</c>, <c>portal_homepage</c>, or <c>redirect</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
