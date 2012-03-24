using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeSubscriptionBase
	{
		[JsonProperty("trial_start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? TrialStart { get; set; }

		[JsonProperty("trial_end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? TrialEnd { get; set; }

		[JsonProperty("plan")]
		public StripePlan StripePlan { get; set; }
	}
}