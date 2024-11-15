// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkAfterCompletion : StripeEntity<PaymentLinkAfterCompletion>
    {
        [JsonProperty("hosted_confirmation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_confirmation")]
#endif

        public PaymentLinkAfterCompletionHostedConfirmation HostedConfirmation { get; set; }

        [JsonProperty("redirect")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect")]
#endif

        public PaymentLinkAfterCompletionRedirect Redirect { get; set; }

        /// <summary>
        /// The specified behavior after the purchase is complete.
        /// One of: <c>hosted_confirmation</c>, or <c>redirect</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
