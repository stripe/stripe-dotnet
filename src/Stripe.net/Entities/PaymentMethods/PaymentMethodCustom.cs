// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodCustom : StripeEntity<PaymentMethodCustom>
    {
        /// <summary>
        /// Display name of the Dashboard-only CustomPaymentMethodType.
        /// </summary>
        [JsonProperty("display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("display_name")]
#endif
        public string DisplayName { get; set; }

        /// <summary>
        /// Contains information about the Dashboard-only CustomPaymentMethodType logo.
        /// </summary>
        [JsonProperty("logo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("logo")]
#endif
        public PaymentMethodCustomLogo Logo { get; set; }

        /// <summary>
        /// ID of the Dashboard-only CustomPaymentMethodType. Not expandable.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
