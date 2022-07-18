// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderLineItemOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// The description for the line item. Will default to the name of the associated product.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The discounts applied to this line item.
        /// </summary>
        [JsonProperty("discounts")]
        public List<OrderLineItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// The ID of an existing line item on the order.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the price object. One of <c>product</c> (with default price) or <c>price</c>
        /// or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline. One of <c>product</c> (with default price) or <c>price</c> or
        /// <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price_data")]
        public OrderLineItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The product of the line item. The product must have a default price specified. One of
        /// <c>product</c> (with default price) or <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates applied to this line item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
