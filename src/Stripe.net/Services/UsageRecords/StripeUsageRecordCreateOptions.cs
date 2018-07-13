namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeUsageRecordCreateOptions : StripeBaseOptions
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonIgnore]
        public string SubscriptionItem { get; set; }

        public DateTime Timestamp { get; set; }

        [JsonProperty("timestamp")]
        internal string TimestampInternal
        {
            get { return Timestamp.ConvertDateTimeToEpoch().ToString(); }
        }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}