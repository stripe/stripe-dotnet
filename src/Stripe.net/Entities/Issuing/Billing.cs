namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class Billing : StripeEntity
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}