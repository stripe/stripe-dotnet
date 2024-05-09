// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionSavedPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Controls which payment methods are eligible to be redisplayed to returning customers.
        /// Corresponds to <c>allow_redisplay</c> on the payment method.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("allow_redisplay_filters")]
        public List<string> AllowRedisplayFilters { get; set; }

        /// <summary>
        /// Enable customers to choose if they wish to save their payment method for future use.
        /// Disabled by default.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_save")]
        public string PaymentMethodSave { get; set; }
    }
}
