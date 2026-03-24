// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkAfterCompletionHostedConfirmationOptions : INestedOptions
    {
        /// <summary>
        /// A custom message to display to the customer after the purchase is complete.
        /// </summary>
        [JsonProperty("custom_message")]
        [STJS.JsonPropertyName("custom_message")]
        public string CustomMessage { get; set; }
    }
}
