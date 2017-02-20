using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOrderItem : StripeOrderItemBase
    {
        /// <summary>
        /// Gets or sets the object Type. value is "order_item"
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Gets or sets a 3-letter ISO code representing the currency in which the order was made.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
