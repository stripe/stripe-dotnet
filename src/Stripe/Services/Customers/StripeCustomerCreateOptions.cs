using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

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

		[JsonProperty("account_balance")]
		public int? AccountBalance { get; set; }

		[JsonProperty("plan")]
		public string PlanId { get; set; }

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

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}
