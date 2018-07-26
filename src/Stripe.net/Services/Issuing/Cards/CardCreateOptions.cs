namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardCreateOptions : CardSharedOptions
    {
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shipping")]
        public CardShippingOptions Shipping { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
