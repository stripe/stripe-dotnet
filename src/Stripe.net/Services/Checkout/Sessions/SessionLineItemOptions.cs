// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionLineItemOptions : INestedOptions, IHasMetadata, IHasId
    {
        /// <summary>
        /// When set, provides configuration for this item’s quantity to be adjusted by the customer
        /// during Checkout.
        /// </summary>
        [JsonProperty("adjustable_quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("adjustable_quantity")]
#endif
        public SessionLineItemAdjustableQuantityOptions AdjustableQuantity { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/api/tax_rates">tax rates</a> that will be applied
        /// to this line item depending on the customer's billing/shipping address. We currently
        /// support the following countries: US, GB, AU, and all countries in the EU.
        /// </summary>
        [JsonProperty("dynamic_tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dynamic_tax_rates")]
#endif
        public List<string> DynamicTaxRates { get; set; }

        /// <summary>
        /// ID of an existing line item.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the <a href="https://docs.stripe.com/api/prices">Price</a> or <a
        /// href="https://docs.stripe.com/api/plans">Plan</a> object. One of <c>price</c> or
        /// <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price")]
#endif
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/prices">Price</a>
        /// object inline. One of <c>price</c> or <c>price_data</c> is required when creating a new
        /// line item.
        /// </summary>
        [JsonProperty("price_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("price_data")]
#endif
        public SessionLineItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// The quantity of the line item being purchased. Quantity should not be defined when
        /// <c>recurring.usage_type=metered</c>.
        /// </summary>
        [JsonProperty("quantity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quantity")]
#endif
        public long? Quantity { get; set; }

        /// <summary>
        /// The <a href="https://docs.stripe.com/api/tax_rates">tax rates</a> which apply to this
        /// line item.
        /// </summary>
        [JsonProperty("tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_rates")]
#endif
        public List<string> TaxRates { get; set; }
    }
}
