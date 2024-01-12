// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for buy button.
        /// </summary>
        [JsonProperty("buy_button")]
        public CustomerSessionComponentsBuyButtonOptions BuyButton { get; set; }

        /// <summary>
        /// Configuration for the pricing table.
        /// </summary>
        [JsonProperty("pricing_table")]
        public CustomerSessionComponentsPricingTableOptions PricingTable { get; set; }
    }
}
