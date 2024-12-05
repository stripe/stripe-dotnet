// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodConfigurationOxxoDisplayPreferenceOptions : INestedOptions
    {
        /// <summary>
        /// The account's preference for whether or not to display this payment method.
        /// One of: <c>none</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
        public string Preference { get; set; }
    }
}
