// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsUpi : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsUpi>
    {
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsUpiMandateOptions MandateOptions { get; set; }
    }
}
