// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkAfterCompletionOptions : INestedOptions
    {
        /// <summary>
        /// Configuration when <c>type=hosted_confirmation</c>.
        /// </summary>
        [JsonProperty("hosted_confirmation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_confirmation")]
#endif

        public PaymentLinkAfterCompletionHostedConfirmationOptions HostedConfirmation { get; set; }

        /// <summary>
        /// Configuration when <c>type=redirect</c>.
        /// </summary>
        [JsonProperty("redirect")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("redirect")]
#endif

        public PaymentLinkAfterCompletionRedirectOptions Redirect { get; set; }

        /// <summary>
        /// The specified behavior after the purchase is complete. Either <c>redirect</c> or
        /// <c>hosted_confirmation</c>.
        /// One of: <c>hosted_confirmation</c>, or <c>redirect</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
