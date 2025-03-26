// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodConfigurationSwish : StripeEntity<PaymentMethodConfigurationSwish>
    {
        /// <summary>
        /// Whether this payment method may be offered at checkout. True if
        /// <c>display_preference</c> is <c>on</c> and the payment method's capability is active.
        /// </summary>
        [JsonProperty("available")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("available")]
#endif
        public bool Available { get; set; }

        [JsonProperty("display_preference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_preference")]
#endif
        public PaymentMethodConfigurationSwishDisplayPreference DisplayPreference { get; set; }
    }
}
