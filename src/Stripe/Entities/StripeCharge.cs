using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;

namespace Stripe
{
	public class StripeCharge : StripeObject
	{
		[JsonProperty("amount")]
		public int? Amount { get; set; }

		[JsonProperty("amount_refunded")]
		public int? AmountRefunded { get; set; }

		public string BalanceTransactionId { get; set; }
		public StripeBalanceTransaction BalanceTransaction { get; set;}

		[JsonProperty("balance_transaction")]
		internal object InternalBalanceTransaction
		{
			set
			{
				ExpandableProperty<StripeBalanceTransaction>.Map(value, s => BalanceTransactionId = s, o => BalanceTransaction = o);
			}
		}

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		public string CustomerId { get; set; }
		public StripeCustomer Customer { get; set; }

		[JsonProperty("customer")]
		internal object InternalCustomer
		{
			set
			{
				ExpandableProperty<StripeCustomer>.Map(value, s => CustomerId = s, o => Customer = o);
			}
		}

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("paid")]
		public bool? Paid { get; set; }

		[JsonProperty("refunded")]
		public bool? Refunded { get; set; }

        [JsonProperty("refunds")]
        public StripeRefundList StripeRefundList { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("card")]
		public StripeCard StripeCard { get; set; }

		public string InvoiceId { get; set; }
		public StripeInvoice Invoice { get; set; }

		[JsonProperty("invoice")]
		internal object InternalInvoice
		{
			set
			{
				ExpandableProperty<StripeInvoice>.Map(value, s => InvoiceId = s, o => Invoice = o);
			}
		}

		[JsonProperty("failure_message")]
		public string FailureMessage { get; private set; }

		[JsonProperty("failure_code")]
		public string FailureCode { get; private set; }

		[JsonProperty("captured")]
		public bool? Captured { get; set; }

        [JsonProperty("dispute")]
        public StripeDispute Dispute { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }

        public StripeRefund Refund(StripeRefundCreateOptions createOptions, string apiKey = null)
        {
            StripeRefundService _stripeRefundService = new StripeRefundService(apiKey);
            StripeChargeService _stripeChargeService = new StripeChargeService(apiKey);

            var stripeRefund = _stripeRefundService.Create(Id, createOptions);

            var stripeCharge = _stripeChargeService.Get(Id);
            this.Refunded = stripeCharge.Refunded;
            this.AmountRefunded = stripeCharge.AmountRefunded;
            this.StripeRefundList = stripeCharge.StripeRefundList;

            return stripeRefund;
        }

        public StripeRefund Refund(int amount, string apiKey = null)
        {
            return Refund(new StripeRefundCreateOptions { Amount = amount }, apiKey);
        }
	}
}