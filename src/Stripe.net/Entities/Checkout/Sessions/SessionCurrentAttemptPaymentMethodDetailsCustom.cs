// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCurrentAttemptPaymentMethodDetailsCustom : StripeEntity<SessionCurrentAttemptPaymentMethodDetailsCustom>
    {
        /// <summary>
        /// ID of the Dashboard-only CustomPaymentMethodType. Not expandable.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
