namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeShippingOptions : ShippingOptions
    {
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
