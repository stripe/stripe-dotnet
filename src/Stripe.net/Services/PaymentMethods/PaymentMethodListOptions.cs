namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentMethodListOptions : ListOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
