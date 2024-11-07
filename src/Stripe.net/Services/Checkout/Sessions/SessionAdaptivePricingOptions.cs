// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionAdaptivePricingOptions : INestedOptions
    {
        /// <summary>
        /// Set to <c>true</c> to enable <a
        /// href="https://docs.stripe.com/payments/checkout/adaptive-pricing">Adaptive Pricing</a>.
        /// Defaults to your <a
        /// href="https://dashboard.stripe.com/settings/adaptive-pricing">dashboard setting</a>.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}
