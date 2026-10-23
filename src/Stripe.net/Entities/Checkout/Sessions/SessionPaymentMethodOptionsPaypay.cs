// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPaymentMethodOptionsPaypay : StripeEntity<SessionPaymentMethodOptionsPaypay>
    {
        /// <summary>
        /// A reference to the merchant subscription this payment corresponds to.
        /// </summary>
        [JsonProperty("subscription_reference")]
        [STJS.JsonPropertyName("subscription_reference")]
        public string SubscriptionReference { get; set; }
    }
}
