namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderAuthorizationControlsSpendingLimitOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }
    }
}
