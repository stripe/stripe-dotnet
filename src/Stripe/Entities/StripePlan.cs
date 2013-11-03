using Newtonsoft.Json;

namespace Stripe
{
	public class StripePlan
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Display name of the plan.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Three-letter ISO currency code. The currency in which the subscription
		/// will be charged.
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }

		/// <summary>
		/// The amount in cents to be charged on the interval specified.
		/// </summary>
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		/// <summary>
		/// One of 'week', 'month' or 'year'. The frequency with which a subscription
		/// should be billed.
		/// </summary>
		[JsonProperty("interval")]
		public string Interval { get; set; }

		[JsonProperty("interval_count")]
		public int IntervalCount { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		/// <summary>
		/// Number of trial period days granted when subscribing a customer to this
		/// plan. Null if the plan has no trial period.
		/// </summary>
		[JsonProperty("trial_period_days")]
		public int? TrialPeriodDays { get; set; }
	}
}