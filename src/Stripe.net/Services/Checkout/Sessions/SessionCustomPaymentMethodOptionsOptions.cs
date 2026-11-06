// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionCustomPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Use <c>off_session</c> to set up this custom payment method for future payments when the
        /// customer is absent. Use <c>none</c> to disable setup for future usage.
        /// One of: <c>none</c>, or <c>off_session</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        [STJS.JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
