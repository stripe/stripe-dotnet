using Newtonsoft.Json;

namespace Stripe
{
    public class StripeChargeShippingOptions : StripeShippingOptions
    {
        [JsonProperty("shipping[carrier]")]
        public string Carrier { get; set; }

        [JsonProperty("shipping[tracking_number]")]
        public string TrackingNumber { get; set; }
    }
}
