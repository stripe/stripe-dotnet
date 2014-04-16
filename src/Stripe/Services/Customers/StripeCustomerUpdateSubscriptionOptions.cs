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

		[JsonProperty("quantity")]
		public int? Quantity { get; set; }

		[JsonProperty("trial_end")]
		internal long? TrialEndInternal
		{
			get
			{
				if (!TrialEnd.HasValue) return null;

				return EpochTime.ConvertDateTimeToEpoch(TrialEnd.Value);
			}
		}
	}
}
