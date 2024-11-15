// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkAfterCompletionRedirect : StripeEntity<PaymentLinkAfterCompletionRedirect>
    {
        /// <summary>
        /// The URL the customer will be redirected to after the purchase is complete.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif

        public string Url { get; set; }
    }
}
