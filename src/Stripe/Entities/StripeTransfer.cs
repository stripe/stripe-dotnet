using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;

namespace Stripe
{
	public class StripeTransfer : StripeObject
	{
		[JsonProperty("object")]
		public string Object { get; set; }

		[JsonProperty("livemode")]
		public bool LiveMode { get; set; }

		[JsonProperty("amount")]
		public int? Amount { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Date { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("bank_account[id]")]
		public string AccountId { get; set; }

        [JsonProperty("bank_account[object]")]
		public string AccountObject { get; set; }

        [JsonProperty("bank_account[bank_name]")]
		public string AccountBankName { get; set; }

        [JsonProperty("bank_account[country]")]
		public string AccountCountry { get; set; }

        [JsonProperty("bank_account[currency]")]
		public string AccountCurrency { get; set; }

        [JsonProperty("bank_account[last4]")]
		public string AccountLast4 { get; set; }

        [JsonProperty("bank_account[fingerprint]")]
		public string AccountFingerprint { get; set; }

        [JsonProperty("bank_account[validated]")]
		public bool? AccountValidated { get; set; }

        [JsonProperty("bank_account[verified]")]
		public bool? AccountVerified { get; set; }

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

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("statement_description")]
		public string StatementDescription { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }

		[JsonProperty("recipient")]
		public string RecipientId { get; set; }
	}
}