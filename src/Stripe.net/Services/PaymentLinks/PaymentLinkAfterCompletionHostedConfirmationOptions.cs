// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkAfterCompletionHostedConfirmationOptions : INestedOptions
    {
        /// <summary>
        /// A custom message to display to the customer after the purchase is complete.
        /// </summary>
        [JsonProperty("custom_message")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_message")]
#endif

        public string CustomMessage { get; set; }
    }
}
