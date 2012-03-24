using System;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCustomerCreateOptions : CreditCardOptions
	{
		[JsonProperty("coupon")]
		public string CouponId { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("plan")]
		public string PlanId { get; set; }

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
