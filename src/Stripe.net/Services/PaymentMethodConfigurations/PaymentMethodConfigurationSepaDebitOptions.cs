// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodConfigurationSepaDebitOptions : INestedOptions
    {
        /// <summary>
        /// Whether or not the payment method should be displayed.
        /// </summary>
        [JsonProperty("display_preference")]
        public PaymentMethodConfigurationSepaDebitDisplayPreferenceOptions DisplayPreference { get; set; }
    }
}
