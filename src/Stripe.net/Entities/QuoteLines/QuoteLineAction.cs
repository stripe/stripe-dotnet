// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class QuoteLineAction : StripeEntity<QuoteLineAction>
    {
        /// <summary>
        /// Details for the <c>add_discount</c> type.
        /// </summary>
        [JsonProperty("add_discount")]
        public QuoteLineActionAddDiscount AddDiscount { get; set; }

        /// <summary>
        /// Details for the <c>add_item</c> type.
        /// </summary>
        [JsonProperty("add_item")]
        public QuoteLineActionAddItem AddItem { get; set; }

        /// <summary>
        /// Details for the <c>add_metadata</c> type: specify a hash of key-value pairs.
        /// </summary>
        [JsonProperty("add_metadata")]
        public Dictionary<string, string> AddMetadata { get; set; }

        /// <summary>
        /// Details for the <c>remove_discount</c> type.
        /// </summary>
        [JsonProperty("remove_discount")]
        public QuoteLineActionRemoveDiscount RemoveDiscount { get; set; }

        /// <summary>
        /// Details for the <c>remove_item</c> type.
        /// </summary>
        [JsonProperty("remove_item")]
        public QuoteLineActionRemoveItem RemoveItem { get; set; }

        /// <summary>
        /// Details for the <c>remove_metadata</c> type: specify an array of metadata keys.
        /// </summary>
        [JsonProperty("remove_metadata")]
        public List<string> RemoveMetadata { get; set; }

        /// <summary>
        /// Details for the <c>set_discounts</c> type.
        /// </summary>
        [JsonProperty("set_discounts")]
        public List<QuoteLineActionSetDiscount> SetDiscounts { get; set; }

        /// <summary>
        /// Details for the <c>set_items</c> type.
        /// </summary>
        [JsonProperty("set_items")]
        public List<QuoteLineActionSetItem> SetItems { get; set; }

        /// <summary>
        /// Details for the <c>set_metadata</c> type: specify an array of key-value pairs.
        /// </summary>
        [JsonProperty("set_metadata")]
        public Dictionary<string, string> SetMetadata { get; set; }

        /// <summary>
        /// The type of action the quote line performs.
        /// One of: <c>add_discount</c>, <c>add_item</c>, <c>add_metadata</c>,
        /// <c>clear_discounts</c>, <c>clear_metadata</c>, <c>remove_discount</c>,
        /// <c>remove_item</c>, <c>remove_metadata</c>, <c>set_discounts</c>, <c>set_items</c>, or
        /// <c>set_metadata</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
