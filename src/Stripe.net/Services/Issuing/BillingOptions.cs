namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;

    public class BillingOptions : INestedOptions
    {
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        [Obsolete]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
