// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerSessionComponents : StripeEntity<CustomerSessionComponents>
    {
        /// <summary>
        /// This hash contains whether the buy button is enabled.
        /// </summary>
        [JsonProperty("buy_button")]
        [STJS.JsonPropertyName("buy_button")]
        public CustomerSessionComponentsBuyButton BuyButton { get; set; }

        /// <summary>
        /// This hash contains whether the customer sheet is enabled and the features it supports.
        /// </summary>
        [JsonProperty("customer_sheet")]
        [STJS.JsonPropertyName("customer_sheet")]
        public CustomerSessionComponentsCustomerSheet CustomerSheet { get; set; }

        /// <summary>
        /// This hash contains whether the mobile payment element is enabled and the features it
        /// supports.
        /// </summary>
        [JsonProperty("mobile_payment_element")]
        [STJS.JsonPropertyName("mobile_payment_element")]
        public CustomerSessionComponentsMobilePaymentElement MobilePaymentElement { get; set; }

        /// <summary>
        /// This hash contains whether the Payment Element is enabled and the features it supports.
        /// </summary>
        [JsonProperty("payment_element")]
        [STJS.JsonPropertyName("payment_element")]
        public CustomerSessionComponentsPaymentElement PaymentElement { get; set; }

        /// <summary>
        /// This hash contains whether the pricing table is enabled.
        /// </summary>
        [JsonProperty("pricing_table")]
        [STJS.JsonPropertyName("pricing_table")]
        public CustomerSessionComponentsPricingTable PricingTable { get; set; }

        /// <summary>
        /// This hash contains whether the Tax ID Element is enabled and the features it supports.
        /// </summary>
        [JsonProperty("tax_id_element")]
        [STJS.JsonPropertyName("tax_id_element")]
        public CustomerSessionComponentsTaxIdElement TaxIdElement { get; set; }
    }
}
