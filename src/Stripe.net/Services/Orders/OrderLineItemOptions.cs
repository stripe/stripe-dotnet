// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OrderLineItemOptions : INestedOptions, IHasId, IHasSetTracking
    {
        private List<OrderLineItemDiscountOptions> discounts;
        private List<string> taxRates;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The description for the line item. Will default to the name of the associated product.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The discounts applied to this line item.
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("discounts")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<OrderLineItemDiscountOptions> Discounts
        {
            get => this.discounts;
            set
            {
                this.discounts = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// The ID of an existing line item on the order.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of a <a href="https://docs.stripe.com/api/prices">Price</a> to add to the Order.
        ///
        /// The <c>price</c> parameter is an alternative to using the <c>product</c> parameter. If
        /// each of your products are sold at a single price, you can set
        /// <c>Product.default_price</c> and then pass the <c>product</c> parameter when creating a
        /// line item. If your products are sold at several possible prices, use the <c>price</c>
        /// parameter to explicitly specify which one to use.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new Price object inline.
        ///
        /// The <c>price_data</c> parameter is an alternative to using the <c>product</c> or
        /// <c>price</c> parameters. If you create a Product upfront and configure a
        /// <c>Product.default_price</c>, pass the <c>product</c> parameter when creating a line
        /// item. If you prefer not to define Products upfront, or if you charge variable prices,
        /// pass the <c>price_data</c> parameter to describe the price for this line item.
        ///
        /// Each time you pass <c>price_data</c> we create a Price for the Product. This Price is
        /// hidden in both the Dashboard and API lists and cannot be reused.
        /// </summary>
        [JsonProperty("price_data")]
        [STJS.JsonPropertyName("price_data")]
        public OrderLineItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The ID of a <a href="https://docs.stripe.com/api/products">Product</a> to add to the
        /// Order.
        ///
        /// The Product must have a <c>default_price</c> specified. Otherwise, specify the price by
        /// passing the <c>price</c> or <c>price_data</c> parameter.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// Defines a <a href="https://docs.stripe.com/api/products">Product</a> inline and adds it
        /// to the Order.
        ///
        /// <c>product_data</c> is an alternative to the <c>product</c> parameter. If you created a
        /// Product upfront, use the <c>product</c> parameter to refer to the existing Product. But
        /// if you prefer not to create Products upfront, pass the <c>product_data</c> parameter to
        /// define a Product inline as part of configuring the Order.
        ///
        /// <c>product_data</c> automatically creates a Product, just as if you had manually created
        /// the Product. If a Product with the same ID already exists, then <c>product_data</c>
        /// re-uses it to avoid duplicates.
        /// </summary>
        [JsonProperty("product_data")]
        [STJS.JsonPropertyName("product_data")]
        public OrderLineItemProductDataOptions ProductData { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates applied to this line item.
        /// </summary>
        [JsonProperty("tax_rates", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("tax_rates")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public List<string> TaxRates
        {
            get => this.taxRates;
            set
            {
                this.taxRates = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
