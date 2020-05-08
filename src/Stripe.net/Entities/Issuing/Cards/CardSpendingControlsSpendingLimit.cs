namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardSpendingControlsSpendingLimit : StripeEntity<CardSpendingControlsSpendingLimit>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }
    }
}
