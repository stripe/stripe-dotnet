// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponents : StripeEntity<CustomerSessionComponents>
    {
        /// <summary>
        /// This hash contains whether the buy button is enabled.
        /// </summary>
        [JsonProperty("buy_button")]
        public CustomerSessionComponentsBuyButton BuyButton { get; set; }

        /// <summary>
        /// This hash contains whether the pricing table is enabled.
        /// </summary>
        [JsonProperty("pricing_table")]
        public CustomerSessionComponentsPricingTable PricingTable { get; set; }
    }
}
