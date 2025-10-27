// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerSessionComponents : StripeEntity<CustomerSessionComponents>
    {
        /// <summary>
        /// This hash contains whether the buy button is enabled.
        /// </summary>
        [JsonProperty("buy_button")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("buy_button")]
#endif
        public CustomerSessionComponentsBuyButton BuyButton { get; set; }

        /// <summary>
        /// This hash contains whether the customer sheet is enabled and the features it supports.
        /// </summary>
        [JsonProperty("customer_sheet")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_sheet")]
#endif
        public CustomerSessionComponentsCustomerSheet CustomerSheet { get; set; }

        /// <summary>
        /// This hash contains whether the mobile payment element is enabled and the features it
        /// supports.
        /// </summary>
        [JsonProperty("mobile_payment_element")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mobile_payment_element")]
#endif
        public CustomerSessionComponentsMobilePaymentElement MobilePaymentElement { get; set; }

        /// <summary>
        /// This hash contains whether the Payment Element is enabled and the features it supports.
        /// </summary>
        [JsonProperty("payment_element")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_element")]
#endif
        public CustomerSessionComponentsPaymentElement PaymentElement { get; set; }

        /// <summary>
        /// This hash contains whether the pricing table is enabled.
        /// </summary>
        [JsonProperty("pricing_table")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pricing_table")]
#endif
        public CustomerSessionComponentsPricingTable PricingTable { get; set; }

        /// <summary>
        /// This hash contains whether the Tax ID Element is enabled and the features it supports.
        /// </summary>
        [JsonProperty("tax_id_element")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id_element")]
#endif
        public CustomerSessionComponentsTaxIdElement TaxIdElement { get; set; }
    }
}
