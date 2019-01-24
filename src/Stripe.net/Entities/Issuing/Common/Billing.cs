namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class Billing : StripeEntity<Billing>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
