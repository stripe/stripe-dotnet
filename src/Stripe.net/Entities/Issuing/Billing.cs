namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class Billing : StripeEntity
    {
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }
    }
}