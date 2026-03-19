// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionAdaptivePricingOptions : INestedOptions
    {
        /// <summary>
        /// If set to <c>true</c>, Adaptive Pricing is available on <a
        /// href="https://docs.stripe.com/payments/currencies/localize-prices/adaptive-pricing?payment-ui=stripe-hosted#restrictions">eligible
        /// sessions</a>. Defaults to your <a
        /// href="https://dashboard.stripe.com/settings/adaptive-pricing">dashboard setting</a>.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}
