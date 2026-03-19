// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkAfterCompletion : StripeEntity<PaymentLinkAfterCompletion>
    {
        [JsonProperty("hosted_confirmation")]
        [STJS.JsonPropertyName("hosted_confirmation")]
        public PaymentLinkAfterCompletionHostedConfirmation HostedConfirmation { get; set; }

        [JsonProperty("redirect")]
        [STJS.JsonPropertyName("redirect")]
        public PaymentLinkAfterCompletionRedirect Redirect { get; set; }

        /// <summary>
        /// The specified behavior after the purchase is complete.
        /// One of: <c>hosted_confirmation</c>, or <c>redirect</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
