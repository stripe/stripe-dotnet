using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Stripe
{
	public class StripeApplicationFee : StripeObject
	{
		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		public string AccountId { get; set; }
		public StripeAccount Account { get; set; }

		[JsonProperty("account")]
		internal object InternalAccount
		{
			set
			{
				ExpandableProperty<StripeAccount>.Map(value, s => AccountId = s, o => Account = o);
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
				ExpandableProperty<StripeBalanceTransaction>.Map(value, s => BalanceTransactionId = s, o => BalanceTransaction = o);
			}
		}

		public string CardId { get; set; }
		public StripeCard Card { get; set; }

		internal object InternalCard
		{
			set
			{
				ExpandableProperty<StripeCard>.Map(value, s => CardId = s, o => Card = o);
			}
		}

		public string ChargeId { get; set; }
		public StripeCharge Charge { get; set; }

		[JsonProperty("charge")]
		internal object InternalCharge
		{
			set
			{
				ExpandableProperty<StripeCharge>.Map(value, s => ChargeId = s, o => Charge = o);
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