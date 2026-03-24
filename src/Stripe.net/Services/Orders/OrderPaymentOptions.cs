// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderPaymentOptions : INestedOptions
    {
        /// <summary>
        /// Settings describing how the order should configure generated PaymentIntents.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public OrderPaymentSettingsOptions Settings { get; set; }
    }
}
