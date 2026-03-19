// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodCustom : StripeEntity<PaymentMethodCustom>
    {
        /// <summary>
        /// Display name of the Dashboard-only CustomPaymentMethodType.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Contains information about the Dashboard-only CustomPaymentMethodType logo.
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public PaymentMethodCustomLogo Logo { get; set; }

        /// <summary>
        /// ID of the Dashboard-only CustomPaymentMethodType. Not expandable.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
