using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeInvoice
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Final amount doe at this time for this invoice. If the invoices's total is smaller
		/// than the minimum charge amount, for example, or if there is account credit that can
		/// be applied to the invoice, the <see cref="AmountDueInCents">AmountDueInCents</see>
		/// may be 0. If there is a positive 
		/// <see cref="StartingBalanceInCents">StartingBalanceInCents</see> for the invoice, (the
		/// customer owes money), the <see cref="AmountDueInCents">AmountDueInCents</see> will
		/// also take that into account. The charge that gets generated for the invoice will be
		/// for the amount specified in <see cref="AmountDueInCents">AmountDueInCents</see>.
		/// </summary>
		[JsonProperty("amount_due")]
		public int? AmountDueInCents { get; set; }

		/// <summary>
		/// Number of automatic attempts made for this invoice. Does not include manual attempts
		/// to pay the invoice.
		/// </summary>
		[JsonProperty("attempt_count")]
		public int? AttemptCount { get; set; }

		/// <summary>
		/// Whether or not an attempt has been made to pay the invoice. An invoice is not attempted
		/// until 1 hour after the 'invoice.created' webhook, for example, so you might not want to
		/// display that invoice as unpaid to your users.
		/// </summary>
		[JsonProperty("attempted")]
		public bool? Attempted { get; set; }

		[JsonProperty("charge")]
		public string ChargeId { get; set; }

		/// <summary>
		/// Whether or not the invoice is still trying to collect payment. An invoice is closed if
		/// it's either paid or it has been marked closed. A closed invoice will no longer attempt
		/// to collect payment.
		/// </summary>
		[JsonProperty("closed")]
		public bool? Closed { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		/// <summary>
		/// Three-letter ISO currency code.
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Date { get; set; }

		/// <summary>
		/// Ending customer balance after attempting to pay invoice. If the invoice has not been 
		/// attempted yet, this will be null.
		/// </summary>
		[JsonProperty("ending_balance")]
		public int? EndingBalanceInCents { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("next_payment_attempt")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? NextPaymentAttempt { get; set; }

		[JsonProperty("object")]
		public string Object { get; set; }

		/// <summary>
		/// Whether or not the payment was successfully collected for this invoice. An invoice can
		/// be paid (most commonly) with a charge or with credit from the customer's account balance.
		/// </summary>
		[JsonProperty("paid")]
		public bool? Paid { get; set; }

		/// <summary>
		/// End of the usage period the invoice covers.
		/// </summary>
		[JsonProperty("period_end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? PeriodEnd { get; set; }

		/// <summary>
		/// Start of the usage period the invoice covers.
		/// </summary>
		[JsonProperty("period_start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? PeriodStart { get; set; }

		/// <summary>
		/// Starting customer balance before attempting to pay invoice. If the invoice has not been 
		/// attempted yet, this will be the current customer balance.
		/// </summary>
		[JsonProperty("starting_balance")]
		public int? StartingBalanceInCents { get; set; }

		/// <summary>
		/// Total of all subscriptions, invoice items, and prorations on the invoice before any discount
		/// is applied.
		/// </summary>
		[JsonProperty("subtotal")]
		public int? SubtotalInCents { get; set; }

		/// <summary>
		/// Total after discount.
		/// </summary>
		[JsonProperty("total")]
		public int? TotalInCents { get; set; }

		[JsonProperty("lines")]
		public StripeInvoiceLines StripeInvoiceLines { get; set; }

		[JsonProperty("discount")]
		public StripeDiscount StripeDiscount { get; set; }
	}
}