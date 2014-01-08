using System;
using System.CodeDom;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCustomerCreateOptions : CreditCardOptions
	{
	    public StripeCustomerCreateOptions()
	    {
            Metadata = new Dictionary<string, string>(10);
	    }

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
		internal int? TrialEndInternal
		{
			get
			{
				if (!TrialEnd.HasValue) return null;

				var diff = TrialEnd.Value - new DateTime(1970, 1, 1);

				return (int)Math.Floor(diff.TotalSeconds);
			}
		}

        /// <summary>
        /// Stripe only allows 10 kvps
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
	}
}
