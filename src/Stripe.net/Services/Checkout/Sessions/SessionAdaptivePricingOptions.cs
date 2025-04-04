// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionAdaptivePricingOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable <a
        /// href="https://docs.stripe.com/payments/checkout/adaptive-pricing">Adaptive Pricing</a>.
        /// Defaults to your <a
        /// href="https://dashboard.stripe.com/settings/adaptive-pricing">dashboard setting</a>.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }
    }
}
