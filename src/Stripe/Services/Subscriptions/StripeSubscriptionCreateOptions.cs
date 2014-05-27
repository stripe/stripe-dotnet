using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeSubscriptionCreateOptions : CreditCardOptions
	{
		[JsonProperty("plan")]
		public string PlanId { get; set; }

		[JsonProperty("coupon")]
		public string CouponId { get; set; }

		public DateTime? TrialEnd { get; set; }

		[JsonProperty("trial_end")]
		internal long? TrialEndInternal
		{
			get
			{
				if (!TrialEnd.HasValue) return null;

				return EpochTime.ConvertDateTimeToEpoch(TrialEnd.Value);
			}
		}

		[JsonProperty("quantity")]
		public int? Quantity { get; set; }

		[JsonProperty("application_fee_percent")]
		public decimal? ApplicationFeePercent { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}