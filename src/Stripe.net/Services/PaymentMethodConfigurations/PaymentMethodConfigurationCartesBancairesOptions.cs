// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodConfigurationCartesBancairesOptions : INestedOptions
    {
        /// <summary>
        /// Whether or not the payment method should be displayed.
        /// </summary>
        [JsonProperty("display_preference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_preference")]
#endif
        public PaymentMethodConfigurationCartesBancairesDisplayPreferenceOptions DisplayPreference { get; set; }
    }
}
