// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodConfigurationKrCardOptions : INestedOptions
    {
        /// <summary>
        /// Whether or not the payment method should be displayed.
        /// </summary>
        [JsonProperty("display_preference")]
        [STJS.JsonPropertyName("display_preference")]
        public PaymentMethodConfigurationKrCardDisplayPreferenceOptions DisplayPreference { get; set; }
    }
}
