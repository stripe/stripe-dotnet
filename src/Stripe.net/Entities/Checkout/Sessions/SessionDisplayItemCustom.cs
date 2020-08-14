namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionDisplayItemCustom : StripeEntity<SessionDisplayItemCustom>
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public List<string> Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
