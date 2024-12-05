// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkAfterCompletion : StripeEntity<PaymentLinkAfterCompletion>
    {
        [JsonProperty("hosted_confirmation")]
        public PaymentLinkAfterCompletionHostedConfirmation HostedConfirmation { get; set; }

        [JsonProperty("redirect")]
        public PaymentLinkAfterCompletionRedirect Redirect { get; set; }

        /// <summary>
        /// The specified behavior after the purchase is complete.
        /// One of: <c>hosted_confirmation</c>, or <c>redirect</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
