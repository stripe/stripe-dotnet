using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBitcoin : StripeEntity
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("amount_charged")]
        public int AmountCharged { get; set; }

        [JsonProperty("amount_received")]
        public int AmountReceived { get; set; }

        [JsonProperty("amount_returned")]
        public int AmountReturned { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}
