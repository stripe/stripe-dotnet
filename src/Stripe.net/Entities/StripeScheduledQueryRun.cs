using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeScheduledQueryRun : StripeEntityWithId
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("data_load_time")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime DataLoadTime { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("file")]
        public StripeFileUpload File { get; set; }

        [JsonProperty("result_available_until")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime ResultAvailableUntil { get; set; }

        [JsonProperty("sql")]
        public string Sql { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
