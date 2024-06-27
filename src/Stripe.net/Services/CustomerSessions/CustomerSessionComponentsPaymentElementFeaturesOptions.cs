// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsPaymentElementFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Controls whether the Payment Element displays the option to remove a saved payment
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
        public string PaymentMethodRemove { get; set; }

        /// <summary>
        /// Controls whether the Payment Element displays a checkbox offering to save a new payment
        /// method.
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
        public string PaymentMethodSave { get; set; }

        /// <summary>
        /// Controls whether the Payment Element displays the option to update a saved payment
        /// method.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_update")]
        public string PaymentMethodUpdate { get; set; }
    }
}
