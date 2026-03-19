// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionFlowDataAfterCompletionOptions : INestedOptions
    {
        /// <summary>
        /// Configuration when <c>after_completion.type=hosted_confirmation</c>.
        /// </summary>
        [JsonProperty("hosted_confirmation")]
        [STJS.JsonPropertyName("hosted_confirmation")]
        public SessionFlowDataAfterCompletionHostedConfirmationOptions HostedConfirmation { get; set; }

        /// <summary>
        /// Configuration when <c>after_completion.type=redirect</c>.
        /// </summary>
        [JsonProperty("redirect")]
        [STJS.JsonPropertyName("redirect")]
        public SessionFlowDataAfterCompletionRedirectOptions Redirect { get; set; }

        /// <summary>
        /// The specified behavior after the flow is completed.
        /// One of: <c>hosted_confirmation</c>, <c>portal_homepage</c>, or <c>redirect</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
