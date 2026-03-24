// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleBillingModeOptions : INestedOptions
    {
        /// <summary>
        /// Configure behavior for flexible billing mode.
        /// </summary>
        [JsonProperty("flexible")]
        [STJS.JsonPropertyName("flexible")]
        public SubscriptionScheduleBillingModeFlexibleOptions Flexible { get; set; }

        /// <summary>
        /// Controls the calculation and orchestration of prorations and invoices for subscriptions.
        /// If no value is passed, the default is <c>flexible</c>.
        /// One of: <c>classic</c>, or <c>flexible</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
