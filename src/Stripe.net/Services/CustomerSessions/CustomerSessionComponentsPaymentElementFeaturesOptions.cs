// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerSessionComponentsPaymentElementFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// A list of <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-allow_redisplay"><c>allow_redisplay</c></a>
        /// values that controls which saved payment methods the Payment Element displays by
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
        /// Controls whether or not the Payment Element shows saved payment methods. This parameter
        /// defaults to <c>disabled</c>.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_redisplay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_redisplay")]
#endif
        public string PaymentMethodRedisplay { get; set; }

        /// <summary>
        /// Determines the max number of saved payment methods for the Payment Element to display.
        /// This parameter defaults to <c>3</c>. The maximum redisplay limit is <c>10</c>.
        /// </summary>
        [JsonProperty("payment_method_redisplay_limit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_redisplay_limit")]
#endif
        public long? PaymentMethodRedisplayLimit { get; set; }

        /// <summary>
        /// Controls whether the Payment Element displays the option to remove a saved payment
        /// method. This parameter defaults to <c>disabled</c>.
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
        /// Controls whether the Payment Element displays a checkbox offering to save a new payment
        /// method. This parameter defaults to <c>disabled</c>.
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
        /// When using PaymentIntents and the customer checks the save checkbox, this field
        /// determines the <a
        /// href="https://docs.stripe.com/api/payment_intents/object#payment_intent_object-setup_future_usage"><c>setup_future_usage</c></a>
        /// value used to confirm the PaymentIntent.
        ///
        /// When using SetupIntents, directly configure the <a
        /// href="https://docs.stripe.com/api/setup_intents/object#setup_intent_object-usage"><c>usage</c></a>
        /// value on SetupIntent creation.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("payment_method_save_usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_save_usage")]
#endif
        public string PaymentMethodSaveUsage { get; set; }
    }
}
