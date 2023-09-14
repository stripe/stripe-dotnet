// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodConfigurationKlarnaOptions : INestedOptions
    {
        /// <summary>
        /// Whether or not the payment method should be displayed.
        /// </summary>
        [JsonProperty("display_preference")]
        public PaymentMethodConfigurationKlarnaDisplayPreferenceOptions DisplayPreference { get; set; }
    }
}
