using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
	public class StripeApplicationFee
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("account")]
		public string AccountId { get; set; }

		[JsonProperty("amount")]
		public int Amount { get; set; }

		[JsonProperty("application")]
		public string ApplicationId { get; set; }

		[JsonProperty("balance_transaction")]
		public string BalanceTransaction { get; set; }

		[JsonProperty("charge")]
		public string ChargeId { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("refunded")]
		public bool Refunded { get; set; }

		[JsonProperty("refunds")]
		public List<StripeApplicationFeeRefund> Refunds { get; set; }

		[JsonProperty("amount_refunded")]
		public int AmountRefunded { get; set; }
	}
}