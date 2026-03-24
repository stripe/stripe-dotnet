// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionApproveOptions : BaseOptions
    {
        /// <summary>
        /// The ID of the customer's attempt to pay to approve.
        /// </summary>
        [JsonProperty("attempt")]
        [STJS.JsonPropertyName("attempt")]
        public string Attempt { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to PaymentIntent creation for Checkout Sessions in
        /// <c>payment</c> mode.
        /// </summary>
        [JsonProperty("payment_intent_data")]
        [STJS.JsonPropertyName("payment_intent_data")]
        public SessionPaymentIntentDataOptions PaymentIntentData { get; set; }

        /// <summary>
        /// The URL to redirect your customer back to after they authenticate or cancel their
        /// payment on the payment method's app or site. This parameter is allowed and required if
        /// and only if you did not set the return URL during Checkout Session creation or in
        /// <c>checkout.confirm()</c> in Stripe.js.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// A subset of parameters to be passed to subscription creation for Checkout Sessions in
        /// <c>subscription</c> mode.
        /// </summary>
        [JsonProperty("subscription_data")]
        [STJS.JsonPropertyName("subscription_data")]
        public SessionSubscriptionDataOptions SubscriptionData { get; set; }
    }
}
