using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripePlan : StripeObject
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("amount")]
		public int? Amount { get; set; }

		[JsonProperty("interval")]
		public string Interval { get; set; }

		[JsonProperty("interval_count")]
		public int IntervalCount { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("trial_period_days")]
		public int? TrialPeriodDays { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}