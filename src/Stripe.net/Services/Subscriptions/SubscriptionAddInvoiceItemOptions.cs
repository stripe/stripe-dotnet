// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionAddInvoiceItemOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The coupons to redeem into discounts for the item.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<SubscriptionAddInvoiceItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The period associated with this invoice item. If not set, <c>period.start.type</c>
        /// defaults to <c>max_item_period_start</c> and <c>period.end.type</c> defaults to
        /// <c>min_item_period_end</c>.
        /// </summary>
        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public SubscriptionAddInvoiceItemPeriodOptions Period { get; set; }

        /// <summary>
        /// The ID of the price object. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://docs.stripe.com/api/prices">Price</a>
        /// object inline. One of <c>price</c> or <c>price_data</c> is required.
        /// </summary>
        [JsonProperty("price_data")]
        [STJS.JsonPropertyName("price_data")]
        public SubscriptionAddInvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for this item. Defaults to 1.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the item. When set, the <c>default_tax_rates</c> do not
        /// apply to this item.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
