namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardholderBillingOptions : INestedOptions
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }
    }
}
