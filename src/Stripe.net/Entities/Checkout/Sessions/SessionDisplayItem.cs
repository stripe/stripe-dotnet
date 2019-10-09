namespace Stripe
{
    using Newtonsoft.Json;

    public class SessionDisplayItem : StripeEntity<SessionDisplayItem>
    {
        /// <summary>
        /// Amount for the display item.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Details about the display item if it's of type custom.
        /// </summary>
        [JsonProperty("custom")]
        public SessionDisplayItemCustom Custom { get; set; }

        /// <summary>
        /// The Plan if the display item is of type plan.
        /// </summary>
        [JsonProperty("plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Quantity of the display item being purchased.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The Sku if the display item is of type sku.
        /// </summary>
        [JsonProperty("sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// The type of display item.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
