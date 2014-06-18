using Newtonsoft.Json;
using Stripe.Infrastructure;
using System;

namespace Stripe
{
	public class StripeApplicationFeeRefund
	{
		[JsonProperty("amount")]
		public int Amount { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("balance_transaction")]
		public string BalanceTransaction { get; set; }
	}
}
