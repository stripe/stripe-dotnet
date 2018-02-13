using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSourceMandateNotification : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object => "source_mandate_notification";

        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("source")]
        public StripeSource Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sepa_debit")]
        public StripeSourceMandateNotificationSepaDebit SepaDebit { get; set; }
    }
}
