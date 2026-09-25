// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionSavedPaymentMethodOptions : StripeEntity<SessionSavedPaymentMethodOptions>
    {
        /// <summary>
        /// Uses the <c>allow_redisplay</c> value of each saved payment method to filter the set
        /// presented to a returning customer. By default, only saved payment methods with
        /// ’allow_redisplay: ‘always’ are shown in Checkout.
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("allow_redisplay_filters")]
        [STJS.JsonPropertyName("allow_redisplay_filters")]
        public List<string> AllowRedisplayFilters { get; set; }

        /// <summary>
        /// The ID of a saved payment method to select when the Payment Element renders, for example
        /// <c>pm_1MqLiJLkdIwHu7ixUEgbFdYF</c>. Takes precedence over the customer's default payment
        /// method. If the ID doesn't match one of the payment methods the Element is displaying,
        /// the Element selects a payment method as it normally would and no error is returned.
        /// Preselecting a payment method never changes which payment methods the Element displays,
        /// and never modifies the payment method, the customer, or this session. The preselection
        /// is fixed once set. To preselect a different payment method, create a new session. An
        /// Element that's already on the page keeps its current selection.
        /// </summary>
        [JsonProperty("payment_method_preselect")]
        [STJS.JsonPropertyName("payment_method_preselect")]
        public string PaymentMethodPreselect { get; set; }

        /// <summary>
        /// Enable customers to choose if they wish to remove their saved payment methods. Disabled
        /// by default.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("payment_method_remove")]
        [STJS.JsonPropertyName("payment_method_remove")]
        public string PaymentMethodRemove { get; set; }

        /// <summary>
        /// Enable customers to choose if they wish to save their payment method for future use.
        /// Disabled by default.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("payment_method_save")]
        [STJS.JsonPropertyName("payment_method_save")]
        public string PaymentMethodSave { get; set; }
    }
}
