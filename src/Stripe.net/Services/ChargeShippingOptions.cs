namespace Stripe
{
    using Stripe.Infrastructure;

    public class ChargeShippingOptions : ShippingOptions
    {
        [FormProperty("carrier")]
        public string Carrier { get; set; }

        [FormProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
