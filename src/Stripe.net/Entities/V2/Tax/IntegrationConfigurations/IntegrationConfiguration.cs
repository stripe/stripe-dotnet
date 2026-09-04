// File generated from our OpenAPI spec
namespace Stripe.V2.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Per-account configuration controlling implicit behavior of Stripe Tax across supported
    /// integration surfaces.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntegrationConfiguration : StripeEntity<IntegrationConfiguration>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Configuration for Checkout Sessions automatic tax behavior.
        /// </summary>
        [JsonProperty("checkout_sessions")]
        [STJS.JsonPropertyName("checkout_sessions")]
        public IntegrationConfigurationCheckoutSessions CheckoutSessions { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
