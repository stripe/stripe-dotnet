// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerSessionComponentsCustomerSheetFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// A list of <a
        /// href="https://docs.stripe.com/api/payment_methods/object#payment_method_object-allow_redisplay"><c>allow_redisplay</c></a>
        /// values that controls which saved payment methods the customer sheet displays by
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
        /// Controls whether the customer sheet displays the option to remove a saved payment
        /// method.".
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
    }
}
