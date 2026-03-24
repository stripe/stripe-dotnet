// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionSetReaderDisplayCartLineItem : StripeEntity<ReaderActionSetReaderDisplayCartLineItem>
    {
        /// <summary>
        /// The amount of the line item. A positive integer in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Description of the line item.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The quantity of the line item.
        /// </summary>
        [JsonProperty("quantity")]
        [STJS.JsonPropertyName("quantity")]
        public long Quantity { get; set; }
    }
}
