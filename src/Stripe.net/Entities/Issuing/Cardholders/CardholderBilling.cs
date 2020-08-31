namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderBilling : StripeEntity<CardholderBilling>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
