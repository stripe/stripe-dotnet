// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionFlowDataAfterCompletionHostedConfirmationOptions : INestedOptions
    {
        /// <summary>
        /// A custom message to display to the customer after the flow is completed.
        /// </summary>
        [JsonProperty("custom_message")]
        [STJS.JsonPropertyName("custom_message")]
        public string CustomMessage { get; set; }
    }
}
