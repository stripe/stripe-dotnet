using Newtonsoft.Json;
using System;
namespace Stripe
{
    public class StripeEventSearchOptions
    {
        [JsonProperty("gt")]
		public DateTime? GreaterThan { get; set; }

		[JsonProperty("gte")]
		public DateTime? GreaterThanOrEqualTo { get; set; }

		[JsonProperty("lt")]
		public DateTime? LessThan { get; set; }

		[JsonProperty("lte")]
		public DateTime? LessThanOrEqualTo { get; set; }

    }
}