using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;

namespace Stripe
{
	public class StripeInvoice : StripeObject
	{
		[JsonProperty("amount_due")]
		public int? AmountDue { get; set; }

		[JsonProperty("attempt_count")]
		public int? AttemptCount { get; set; }

		[JsonProperty("attempted")]
		public bool? Attempted { get; set; }

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

		[JsonProperty("closed")]
		public bool? Closed { get; set; }

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

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Date { get; set; }

		[JsonProperty("ending_balance")]
		public int? EndingBalance { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("next_payment_attempt")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? NextPaymentAttempt { get; set; }

		[JsonProperty("object")]
		public string Object { get; set; }

		[JsonProperty("paid")]
		public bool? Paid { get; set; }

		[JsonProperty("period_end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? PeriodEnd { get; set; }

		[JsonProperty("period_start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? PeriodStart { get; set; }

		[JsonProperty("starting_balance")]
		public int? StartingBalance { get; set; }

		[JsonProperty("subtotal")]
		public int? Subtotal { get; set; }

		[JsonProperty("total")]
		public int? Total { get; set; }

		[JsonProperty("lines")]
		public StripeInvoiceLines StripeInvoiceLines { get; set; }

		[JsonProperty("discount")]
		public StripeDiscount StripeDiscount { get; set; }
	}
}