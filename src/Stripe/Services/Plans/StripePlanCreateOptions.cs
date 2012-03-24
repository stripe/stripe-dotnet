using Newtonsoft.Json;

namespace Stripe
{
	public class StripePlanCreateOptions
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("interval")]
		public string Interval { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("trial_period_days")]
		public int? TrialPeriodDays { get; set; }
	}
}
