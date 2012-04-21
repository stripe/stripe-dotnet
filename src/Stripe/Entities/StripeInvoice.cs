using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeInvoice
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("amount_due")]
		public int? AmountDueInCents { get; set; }

		[JsonProperty("attempt_count")]
		public int? AttemptCount { get; set; }

		[JsonProperty("attempted")]
		public bool? Attempted { get; set; }

		[JsonProperty("charge")]
		public string ChargeId { get; set; }

		[JsonProperty("closed")]
		public bool? Closed { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Date { get; set; }

		[JsonProperty("ending_balance")]
		public int? EndingBalanceInCents { get; set; }

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
		public int? StartingBalanceInCents { get; set; }

		[JsonProperty("subtotal")]
		public int? SubtotalInCents { get; set; }

		[JsonProperty("total")]
		public int? TotalInCents { get; set; }

		[JsonProperty("lines")]
		public StripeInvoiceLines StripeInvoiceLines { get; set; }

		[JsonProperty("discount")]
		public StripeDiscount StripeDiscount { get; set; }
	}
}