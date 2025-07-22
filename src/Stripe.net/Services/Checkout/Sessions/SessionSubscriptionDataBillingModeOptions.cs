// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionSubscriptionDataBillingModeOptions : INestedOptions
    {
        /// <summary>
        /// Controls the calculation and orchestration of prorations and invoices for subscriptions.
        /// One of: <c>classic</c>, or <c>flexible</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
