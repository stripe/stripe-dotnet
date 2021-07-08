// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class QuoteLineItemOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The ID of an existing line item on the quote.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the price object. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price_data")]
        public QuoteLineItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the line item. When set, the <c>default_tax_rates</c> on
        /// the quote do not apply to this line item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
