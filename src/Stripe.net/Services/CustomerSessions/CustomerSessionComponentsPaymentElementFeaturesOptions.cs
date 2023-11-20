// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsPaymentElementFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Whether the payment element supports detaching a payment method.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("payment_method_detach")]
        public string PaymentMethodDetach { get; set; }

        /// <summary>
        /// Whether the payment element supports setting a payment method as the customer's default.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("payment_method_set_as_customer_default")]
        public string PaymentMethodSetAsCustomerDefault { get; set; }

        /// <summary>
        /// Whether the payment element supports updating a payment method.
        /// One of: <c>auto</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("payment_method_update")]
        public string PaymentMethodUpdate { get; set; }
    }
}
