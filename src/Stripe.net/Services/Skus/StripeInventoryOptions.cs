namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeInventoryOptions : INestedOptions
    {
        [JsonProperty("inventory[quantity]")]
        public int? Quantity { get; set; }

        [JsonProperty("inventory[type]")]
        public string Type { get; set; }

        [JsonProperty("inventory[value]")]
        public string Value { get; set; }
    }
}
