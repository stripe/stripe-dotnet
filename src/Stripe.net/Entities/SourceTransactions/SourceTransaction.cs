namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceTransaction : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object => "source_transaction";

        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer_data")]
        public string CustomerData { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("ach_credit_transfer")]
        public SourceTransactionAchCreditTransfer AchCreditTransfer { get; set; }
    }
}
