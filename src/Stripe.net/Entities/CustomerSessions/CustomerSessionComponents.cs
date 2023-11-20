// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponents : StripeEntity<CustomerSessionComponents>
    {
        /// <summary>
        /// This hash contains whether the payment element is enabled and the features it supports.
        /// </summary>
        [JsonProperty("payment_element")]
        public CustomerSessionComponentsPaymentElement PaymentElement { get; set; }

        /// <summary>
        /// This hash contains whether the pricing table is enabled.
        /// </summary>
        [JsonProperty("pricing_table")]
        public CustomerSessionComponentsPricingTable PricingTable { get; set; }
    }
}
