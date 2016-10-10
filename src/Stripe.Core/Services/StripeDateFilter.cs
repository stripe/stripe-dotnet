using System;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDateFilter
    {
        [JsonProperty("")]
        public DateTime? EqualTo { get; set; }

        [JsonProperty("[gt]")]
        public DateTime? GreaterThan { get; set; }

        [JsonProperty("[gte]")]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonProperty("[lt]")]
        public DateTime? LessThan { get; set; }

        [JsonProperty("[lte]")]
        public DateTime? LessThanOrEqual { get; set; }
    }
}