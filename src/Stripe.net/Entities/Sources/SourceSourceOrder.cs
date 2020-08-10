namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SourceSourceOrder : StripeEntity<SourceSourceOrder>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("items")]
        public List<SourceSourceOrderItem> Items { get; set; }

        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }
    }
}
