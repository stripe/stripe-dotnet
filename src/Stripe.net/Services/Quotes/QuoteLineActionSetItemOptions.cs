// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QuoteLineActionSetItemOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the
        /// <c>discounts</c> array on the subscription item that matches that price. Otherwise, the
        /// <c>items</c> array is cleared and a single new item is added with the supplied
        /// <c>discounts</c>.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public List<QuoteLineActionSetItemDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the
        /// <c>metadata</c> on the subscription item that matches that price. Otherwise, the
        /// <c>items</c> array is cleared and a single new item is added with the supplied
        /// <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the quantity
        /// on the subscription item that matches that price. Otherwise, the <c>items</c> array is
        /// cleared and a single new item is added with the supplied <c>quantity</c>.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the
        /// <c>tax_rates</c> array on the subscription item that matches that price. Otherwise, the
        /// <c>items</c> array is cleared and a single new item is added with the supplied
        /// <c>tax_rates</c>.
        /// </summary>
        [JsonProperty("tax_rates")]
        [STJS.JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }

        /// <summary>
        /// If an item with the <c>price</c> already exists, passing this will override the
        /// <c>trial</c> configuration on the subscription item that matches that price. Otherwise,
        /// the <c>items</c> array is cleared and a single new item is added with the supplied
        /// <c>trial</c>.
        /// </summary>
        [JsonProperty("trial")]
        [STJS.JsonPropertyName("trial")]
        public QuoteLineActionSetItemTrialOptions Trial { get; set; }

        /// <summary>
        /// The ID of the trial offer to apply to the configuration item.
        /// </summary>
        [JsonProperty("trial_offer")]
        [STJS.JsonPropertyName("trial_offer")]
        public string TrialOffer { get; set; }
    }
}
