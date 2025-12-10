// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkAfterCompletionRedirectOptions : INestedOptions
    {
        /// <summary>
        /// The URL the customer will be redirected to after the purchase is complete. You can embed
        /// <c>{CHECKOUT_SESSION_ID}</c> into the URL to have the <c>id</c> of the completed <a
        /// href="https://docs.stripe.com/api/checkout/sessions/object#checkout_session_object-id">checkout
        /// session</a> included.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
