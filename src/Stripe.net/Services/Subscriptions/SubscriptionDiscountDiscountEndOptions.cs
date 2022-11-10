// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionDiscountDiscountEndOptions : INestedOptions
    {
        /// <summary>
        /// A precise Unix timestamp for the discount to end. Must be in the future.
        /// </summary>
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// The type of calculation made to determine when the discount ends.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
