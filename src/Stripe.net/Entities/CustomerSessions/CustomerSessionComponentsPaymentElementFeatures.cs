// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsPaymentElementFeatures : StripeEntity<CustomerSessionComponentsPaymentElementFeatures>
    {
        /// <summary>
        /// Whether the payment element supports detaching payment methods.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("payment_method_detach")]
        public string PaymentMethodDetach { get; set; }

        /// <summary>
        /// Whether the payment element supports setting payment methods as the customer's default.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("payment_method_set_as_customer_default")]
        public string PaymentMethodSetAsCustomerDefault { get; set; }

        /// <summary>
        /// Whether the payment element supports updating payment methods.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("payment_method_update")]
        public string PaymentMethodUpdate { get; set; }
    }
}
