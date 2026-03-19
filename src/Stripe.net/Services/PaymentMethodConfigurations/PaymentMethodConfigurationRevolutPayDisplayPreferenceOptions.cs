// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodConfigurationRevolutPayDisplayPreferenceOptions : INestedOptions
    {
        /// <summary>
        /// The account's preference for whether or not to display this payment method.
        /// One of: <c>none</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
        [STJS.JsonPropertyName("preference")]
        public string Preference { get; set; }
    }
}
