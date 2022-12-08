// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class SessionFlowDataAfterCompletionHostedConfirmationOptions : INestedOptions
    {
        /// <summary>
        /// A custom message to display to the customer after the flow is completed.
        /// </summary>
        [JsonProperty("custom_message")]
        public string CustomMessage { get; set; }
    }
}
