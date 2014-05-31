using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Stripe
{
	public class StripeApplicationFee
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		public string AccountId { get; set; }
		public StripeAccount Account { get; set; }

		[JsonProperty("account")]
		internal object InternalAccount
		{
			set
			{
				if (value is JObject)
					Account = Mapper<StripeAccount>.MapFromJson(value.ToString());
				else
					AccountId = value == null ? null : value.ToString();
			}
		}

		[JsonProperty("amount")]
		public int Amount { get; set; }

		[JsonProperty("application")]
		public string ApplicationId { get; set; }

		public string BalanceTransactionId { get; set; }
		public StripeBalanceTransaction BalanceTransaction { get; set; }
		[JsonProperty("balance_transaction")]
		internal object InternalBalanceTransaction
		{
			set
			{
				if (value is JObject)
					BalanceTransaction = Mapper<StripeBalanceTransaction>.MapFromJson(value.ToString());
				else
					BalanceTransactionId = value == null ? null : value.ToString();
			}
		}

		public string ChargeId { get; set; }
		public StripeCharge Charge { get; set; }
		[JsonProperty("charge")]
		internal object InternalCharge
		{
			set
			{
				if (value is JObject)
					Charge = Mapper<StripeCharge>.MapFromJson(value.ToString());
				else
					ChargeId = value == null ? null : value.ToString();
			}
		}

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