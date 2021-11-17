// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionLineItemOptions : INestedOptions
    {
        /// <summary>
        /// When set, provides configuration for this item’s quantity to be adjusted by the customer
        /// during Checkout.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
        public SessionLineItemAdjustableQuantityOptions AdjustableQuantity { get; set; }

        /// <summary>
        /// [Deprecated] The amount to be collected per unit of the line item. If specified, must
        /// also pass <c>currency</c> and <c>name</c>.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// [Deprecated] Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>. Required if
        /// <c>amount</c> is passed.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The description for the line item, to be displayed on the Checkout page.
        ///
        /// If using <c>price</c> or <c>price_data</c>, will default to the name of the associated
        /// product.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/tax_rates">tax rates</a> that will be applied
        /// to this line item depending on the customer's billing/shipping address. We currently
        /// support the following countries: US, GB, AU, and all countries in the EU.
        /// </summary>
        [JsonProperty("dynamic_tax_rates")]
        public List<string> DynamicTaxRates { get; set; }

        /// <summary>
        /// [Deprecated] A list of image URLs representing this line item. Each image can be up to 5
        /// MB in size. If passing <c>price</c> or <c>price_data</c>, specify images on the
        /// associated product instead.
        /// </summary>
        [JsonProperty("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// [Deprecated] The name for the item to be displayed on the Checkout page. Required if
        /// <c>amount</c> is passed.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the <a href="https://stripe.com/docs/api/prices">Price</a> or <a
        /// href="https://stripe.com/docs/api/plans">Plan</a> object. One of <c>price</c> or
        /// <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price_data")]
        public SessionLineItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The quantity of the line item being purchased. Quantity should not be defined when
        /// <c>recurring.usage_type=metered</c>.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/tax_rates">tax rates</a> which apply to this
        /// line item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
