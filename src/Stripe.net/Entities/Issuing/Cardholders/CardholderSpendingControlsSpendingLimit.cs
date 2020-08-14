namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderSpendingControlsSpendingLimit : StripeEntity<CardholderSpendingControlsSpendingLimit>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }
    }
}
