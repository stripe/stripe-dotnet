// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsUpiOptions : INestedOptions
    {
        /// <summary>
        /// Configuration options for setting up an eMandate.
        /// </summary>
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsUpiMandateOptionsOptions MandateOptions { get; set; }
    }
}
