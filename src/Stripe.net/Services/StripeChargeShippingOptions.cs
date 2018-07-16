namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeChargeShippingOptions : StripeShippingOptions
    {
        [JsonProperty("shipping[carrier]")]
        public string Carrier { get; set; }

        [JsonProperty("shipping[tracking_number]")]
        public string TrackingNumber { get; set; }
    }
}
