// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineActionOptions : INestedOptions
    {
        /// <summary>
        /// Details for the <c>add_discount</c> type.
        /// </summary>
        [JsonProperty("add_discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("add_discount")]
#endif
        public QuoteLineActionAddDiscountOptions AddDiscount { get; set; }

        /// <summary>
        /// Details for the <c>add_item</c> type.
        /// </summary>
        [JsonProperty("add_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("add_item")]
#endif
        public QuoteLineActionAddItemOptions AddItem { get; set; }

        /// <summary>
        /// Details for the <c>add_metadata</c> type: specify a hash of key-value pairs.
        /// </summary>
        [JsonProperty("add_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("add_metadata")]
#endif
        public Dictionary<string, string> AddMetadata { get; set; }

        /// <summary>
        /// Details for the <c>remove_discount</c> type.
        /// </summary>
        [JsonProperty("remove_discount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remove_discount")]
#endif
        public QuoteLineActionRemoveDiscountOptions RemoveDiscount { get; set; }

        /// <summary>
        /// Details for the <c>remove_item</c> type.
        /// </summary>
        [JsonProperty("remove_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remove_item")]
#endif
        public QuoteLineActionRemoveItemOptions RemoveItem { get; set; }

        /// <summary>
        /// Details for the <c>remove_metadata</c> type: specify an array of metadata keys.
        /// </summary>
        [JsonProperty("remove_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remove_metadata")]
#endif
        public List<string> RemoveMetadata { get; set; }

        /// <summary>
        /// Details for the <c>set_discounts</c> type.
        /// </summary>
        [JsonProperty("set_discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set_discounts")]
#endif
        public List<QuoteLineActionSetDiscountOptions> SetDiscounts { get; set; }

        /// <summary>
        /// Details for the <c>set_items</c> type.
        /// </summary>
        [JsonProperty("set_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set_items")]
#endif
        public List<QuoteLineActionSetItemOptions> SetItems { get; set; }

        /// <summary>
        /// Details for the <c>set_metadata</c> type: specify an array of key-value pairs.
        /// </summary>
        [JsonProperty("set_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set_metadata")]
#endif
        public Dictionary<string, string> SetMetadata { get; set; }

        /// <summary>
        /// The type of action the quote line performs.
        /// One of: <c>add_discount</c>, <c>add_item</c>, <c>add_metadata</c>,
        /// <c>clear_discounts</c>, <c>clear_metadata</c>, <c>remove_discount</c>,
        /// <c>remove_item</c>, <c>remove_metadata</c>, <c>set_discounts</c>, <c>set_items</c>, or
        /// <c>set_metadata</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
