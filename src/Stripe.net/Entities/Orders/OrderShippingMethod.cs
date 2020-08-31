namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderShippingMethod : StripeEntity<OrderShippingMethod>, IHasId
    {
        /// <summary>
        /// A positive integer in the smallest currency unit (that is, 100 cents for $1.00, or 1 for
        /// ¥1, Japanese Yen being a zero-decimal currency) representing the total amount for the
        /// line item.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The estimated delivery date for the given shipping method. Can be either a specific date
        /// or a range.
        /// </summary>
        [JsonProperty("delivery_estimate")]
        public OrderShippingMethodDeliveryEstimate DeliveryEstimate { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
