// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodConfigurationSatispayDisplayPreferenceOptions : INestedOptions
    {
        /// <summary>
        /// The account's preference for whether or not to display this payment method.
        /// One of: <c>none</c>, <c>off</c>, or <c>on</c>.
        /// </summary>
        [JsonProperty("preference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preference")]
#endif
        public string Preference { get; set; }
    }
}
