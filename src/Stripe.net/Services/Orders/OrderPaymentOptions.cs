// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentOptions : INestedOptions
    {
        /// <summary>
        /// Settings describing how the order should configure generated PaymentIntents.
        /// </summary>
        [JsonProperty("settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("settings")]
#endif
        public OrderPaymentSettingsOptions Settings { get; set; }
    }
}
