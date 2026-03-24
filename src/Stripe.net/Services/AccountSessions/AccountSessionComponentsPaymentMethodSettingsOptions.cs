// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSessionComponentsPaymentMethodSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// An empty list, because this embedded component has no features.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public AccountSessionComponentsPaymentMethodSettingsFeaturesOptions Features { get; set; }
    }
}
