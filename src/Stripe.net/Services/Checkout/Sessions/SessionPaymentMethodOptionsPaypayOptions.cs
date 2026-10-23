// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentMethodOptionsPaypayOptions : INestedOptions
    {
        /// <summary>
        /// The merchant's subscription identifier for this off-session charge.
        /// </summary>
        [JsonProperty("subscription_reference")]
        [STJS.JsonPropertyName("subscription_reference")]
        public string SubscriptionReference { get; set; }
    }
}
