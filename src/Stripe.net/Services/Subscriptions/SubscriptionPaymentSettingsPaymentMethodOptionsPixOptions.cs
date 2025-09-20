// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsPixOptions : INestedOptions
    {
        /// <summary>
        /// Configuration options for setting up a mandate.
        /// </summary>
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsPixMandateOptionsOptions MandateOptions { get; set; }
    }
}
