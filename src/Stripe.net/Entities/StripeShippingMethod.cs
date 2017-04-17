using Newtonsoft.Json;

namespace Stripe
{
    public class StripeShippingMethod : StripeEntityWithId
    {
        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for ¥1, Japanese Yen being a 0-decimal currency) representing the total amount for the line item.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 3-letter ISO code representing the currency of the line item.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The estimated delivery date for the given shipping method. Can be either a specific date or a range.
        /// </summary>
        [JsonProperty("delivery_estimate")]
        public StripeDeliveryEstimate DeliveryEstimate { get; set; }

        /// <summary>
        /// Description of the line item, meant to be displayable to the user (e.g., "Express shipping").
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
