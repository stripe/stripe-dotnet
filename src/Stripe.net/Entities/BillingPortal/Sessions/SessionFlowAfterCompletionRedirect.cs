// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowAfterCompletionRedirect : StripeEntity<SessionFlowAfterCompletionRedirect>
    {
        /// <summary>
        /// The URL the customer will be redirected to after the flow is completed.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
