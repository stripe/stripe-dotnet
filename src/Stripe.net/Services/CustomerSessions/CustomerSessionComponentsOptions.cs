// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerSessionComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for buy button.
        /// </summary>
        [JsonProperty("buy_button")]
        [STJS.JsonPropertyName("buy_button")]
        public CustomerSessionComponentsBuyButtonOptions BuyButton { get; set; }

        /// <summary>
        /// Configuration for the customer sheet.
        /// </summary>
        [JsonProperty("customer_sheet")]
        [STJS.JsonPropertyName("customer_sheet")]
        public CustomerSessionComponentsCustomerSheetOptions CustomerSheet { get; set; }

        /// <summary>
        /// Configuration for the mobile payment element.
        /// </summary>
        [JsonProperty("mobile_payment_element")]
        [STJS.JsonPropertyName("mobile_payment_element")]
        public CustomerSessionComponentsMobilePaymentElementOptions MobilePaymentElement { get; set; }

        /// <summary>
        /// Configuration for the Payment Element.
        /// </summary>
        [JsonProperty("payment_element")]
        [STJS.JsonPropertyName("payment_element")]
        public CustomerSessionComponentsPaymentElementOptions PaymentElement { get; set; }

        /// <summary>
        /// Configuration for the pricing table.
        /// </summary>
        [JsonProperty("pricing_table")]
        [STJS.JsonPropertyName("pricing_table")]
        public CustomerSessionComponentsPricingTableOptions PricingTable { get; set; }

        /// <summary>
        /// Configuration for the Tax ID Element.
        /// </summary>
        [JsonProperty("tax_id_element")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_id_element")]
#endif
        public CustomerSessionComponentsTaxIdElementOptions TaxIdElement { get; set; }
    }
}
