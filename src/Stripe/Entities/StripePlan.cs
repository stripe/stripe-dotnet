using System.Collections.Generic;

using Newtonsoft.Json;

namespace Stripe
{
	public class StripePlan
	{
	    public StripePlan()
	    {
	        Metadata = new Dictionary<string, string>(10);
	    }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("interval")]
		public string Interval { get; set; }

		[JsonProperty("interval_count")]
		public int IntervalCount { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("trial_period_days")]
		public int? TrialPeriodDays { get; set; }

        /// <summary>
        /// Stripe only allows 10 kvp's
        /// </summary>
        [JsonProperty("metadata")]
        public IDictionary<string, string> Metadata { get; set; }
	}
}