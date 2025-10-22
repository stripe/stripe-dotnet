// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerSessionComponentsMobilePaymentElementFeatures : StripeEntity<CustomerSessionComponentsMobilePaymentElementFeatures>
    {
        /// <summary>
        /// A list of <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-allow_redisplay"><c>allow_redisplay</c></a>
        /// values that controls which saved payment methods the mobile payment element displays by
        /// filtering to only show payment methods with an <c>allow_redisplay</c> value that is
        /// present in this list.
        ///
        /// If not specified, defaults to ["always"]. In order to display all saved payment methods,
        /// specify ["always", "limited", "unspecified"].
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("payment_method_allow_redisplay_filters")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_allow_redisplay_filters")]
#endif
        public List<string> PaymentMethodAllowRedisplayFilters { get; set; }

        /// <summary>
        /// Controls whether or not the mobile payment element shows saved payment methods.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_redisplay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_redisplay")]
#endif
        public string PaymentMethodRedisplay { get; set; }

        /// <summary>
        /// Controls whether the mobile payment element displays the option to remove a saved
        /// payment method.".
        ///
        /// Allowing buyers to remove their saved payment methods impacts subscriptions that depend
        /// on that payment method. Removing the payment method detaches the <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-customer"><c>customer</c>
        /// object</a> from that <a
        /// href="https://docs.stripe.com/api/payment_methods">PaymentMethod</a>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_remove")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_remove")]
#endif
        public string PaymentMethodRemove { get; set; }

        /// <summary>
        /// Controls whether the mobile payment element displays a checkbox offering to save a new
        /// payment method.
        ///
        /// If a customer checks the box, the <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-allow_redisplay"><c>allow_redisplay</c></a>
        /// value on the PaymentMethod is set to <c>'always'</c> at confirmation time. For
        /// PaymentIntents, the <a
        /// href="https://docs.stripe.com/api/payment_intents/object#payment_intent_object-setup_future_usage"><c>setup_future_usage</c></a>
        /// value is also set to the value defined in <c>payment_method_save_usage</c>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_save")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_save")]
#endif
        public string PaymentMethodSave { get; set; }

        /// <summary>
        /// Allows overriding the value of allow_override when saving a new payment method when
        /// payment_method_save is set to disabled. Use values: "always", "limited", or
        /// "unspecified".
        ///
        /// If not specified, defaults to <c>nil</c> (no override value).
        /// One of: <c>always</c>, <c>limited</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("payment_method_save_allow_redisplay_override")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_save_allow_redisplay_override")]
#endif
        public string PaymentMethodSaveAllowRedisplayOverride { get; set; }
    }
}
