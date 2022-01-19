// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkAfterCompletionHostedConfirmation : StripeEntity<PaymentLinkAfterCompletionHostedConfirmation>
    {
        /// <summary>
        /// The custom message that is displayed to the customer after the purchase is complete.
        /// </summary>
        [JsonProperty("custom_message")]
        public string CustomMessage { get; set; }
    }
}
