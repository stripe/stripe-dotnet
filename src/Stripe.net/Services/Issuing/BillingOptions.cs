namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class BillingOptions : INestedOptions
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
