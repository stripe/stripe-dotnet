namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderShippingMethodDeliveryEstimate : StripeEntity<OrderShippingMethodDeliveryEstimate>
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("earliest")]
        public string Earliest { get; set; }

        [JsonProperty("latest")]
        public string Latest { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
