// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsPaymentElementFeatures : StripeEntity<CustomerSessionComponentsPaymentElementFeatures>
    {
        /// <summary>
        /// Controls whether the Payment Element allows the removal of a saved payment method.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_remove")]
        public string PaymentMethodRemove { get; set; }

        /// <summary>
        /// Controls whether the Payment Element offers to save a new payment method.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_save")]
        public string PaymentMethodSave { get; set; }

        /// <summary>
        /// Controls whether the Payment Element offers to set a payment method as the default.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_set_as_default")]
        public string PaymentMethodSetAsDefault { get; set; }

        /// <summary>
        /// Controls whether the Payment Element allows the updating of a saved payment method.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("payment_method_update")]
        public string PaymentMethodUpdate { get; set; }
    }
}
