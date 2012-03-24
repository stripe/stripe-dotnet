using System;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeInvoiceSubscription
	{
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("plan")]
		public StripePlan StripePlan { get; set; }

		[JsonProperty("period")]
		public StripePeriod StripePeriod { get; set; }
	}
}