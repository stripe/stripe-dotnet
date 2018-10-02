namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReportType : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data_available_end")]
        public DateTime DataAvailableEnd { get; set; }

        [JsonProperty("data_available_start")]
        public DateTime DataAvailableStart { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated")]
        public DateTime Updated { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
