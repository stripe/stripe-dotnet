namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeChargeShippingOptions : StripeShippingOptions
    {
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
