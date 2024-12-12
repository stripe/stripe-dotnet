// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionSavedPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Uses the <c>allow_redisplay</c> value of each saved payment method to filter the set
        /// presented to a returning customer. By default, only saved payment methods with
        /// ’allow_redisplay: ‘always’ are shown in Checkout.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay_filters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_redisplay_filters")]
#endif
        public List<string> AllowRedisplayFilters { get; set; }

        /// <summary>
        /// Enable customers to choose if they wish to save their payment method for future use.
        /// Disabled by default.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_save")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_save")]
#endif
        public string PaymentMethodSave { get; set; }
    }
}
