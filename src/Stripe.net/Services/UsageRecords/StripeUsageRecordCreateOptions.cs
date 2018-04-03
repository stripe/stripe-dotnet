using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeUsageRecordCreateOptions : StripeBaseOptions
    {
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