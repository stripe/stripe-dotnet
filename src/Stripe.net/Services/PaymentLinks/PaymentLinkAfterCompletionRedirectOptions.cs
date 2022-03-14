// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkAfterCompletionRedirectOptions : INestedOptions
    {
        /// <summary>
        /// The URL the customer will be redirected to after the purchase is complete. You can embed
        /// <c>{CHECKOUT_SESSION_ID}</c> into the URL to have the <c>id</c> of the completed <a
        /// href="https://stripe.com/docs/api/checkout/sessions/object#checkout_session_object-id">checkout
        /// session</a> included.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
