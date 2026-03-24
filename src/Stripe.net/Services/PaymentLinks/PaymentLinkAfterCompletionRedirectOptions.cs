// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkAfterCompletionRedirectOptions : INestedOptions
    {
        /// <summary>
        /// The URL the customer will be redirected to after the purchase is complete. You can embed
        /// <c>{CHECKOUT_SESSION_ID}</c> into the URL to have the <c>id</c> of the completed <a
        /// href="https://docs.stripe.com/api/checkout/sessions/object#checkout_session_object-id">checkout
        /// session</a> included.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
