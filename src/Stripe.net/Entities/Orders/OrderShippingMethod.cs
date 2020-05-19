namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderShippingMethod : StripeEntity<OrderShippingMethod>, IHasId
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("delivery_estimate")]
        public OrderShippingMethodDeliveryEstimate DeliveryEstimate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
