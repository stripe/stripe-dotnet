namespace Stripe.Reporting
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ReportType : StripeEntity<ReportType>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("data_available_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DataAvailableEnd { get; set; }

        [JsonProperty("data_available_start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DataAvailableStart { get; set; }

        [JsonProperty("default_columns")]
        public List<string> DefaultColumns { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Updated { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }
}
