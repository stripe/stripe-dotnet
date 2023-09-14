// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodConfigurationCartesBancairesOptions : INestedOptions
    {
        /// <summary>
        /// Whether or not the payment method should be displayed.
        /// </summary>
        [JsonProperty("display_preference")]
        public PaymentMethodConfigurationCartesBancairesDisplayPreferenceOptions DisplayPreference { get; set; }
    }
}
