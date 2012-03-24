using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeCustomerUpdateSubscriptionOptions : CreditCardOptions
	{
		[JsonProperty("plan")]
		public string PlanId { get; set; }

		[JsonProperty("coupon")]
		public string CouponId { get; set; }

		[JsonProperty("prorate")]
		public bool? Prorate { get; set; }

		public DateTime? TrialEnd { get; set; }

		[JsonProperty("trial_end")]
		internal int? TrialEndInternal
		{
			get
			{
				if (!TrialEnd.HasValue) return null;

				var diff = TrialEnd.Value - new DateTime(1970, 1, 1);

				return (int)Math.Floor(diff.TotalSeconds);
			}
		}
	}
}
