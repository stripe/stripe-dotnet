namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceMandateNotification : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object => "source_mandate_notification";

        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sepa_debit")]
        public SourceMandateNotificationSepaDebit SepaDebit { get; set; }
    }
}
