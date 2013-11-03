using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeDispute
	{
		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		/// <summary>
		/// Disputed amount. Usually the amount of the charge, but can differ (usually
		/// because of currency fluctuation or because only party of the order is 
		/// disputed).
		/// </summary>
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		/// <summary>
		/// ID of the charge that was disputed.
		/// </summary>
		[JsonProperty("charge")]
		public string ChargeId { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Created { get; set; }

		/// <summary>
		/// Three-letter ISO currency code.
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }

		/// <summary>
		/// Date by which evidence must be submitted in order to successfully challenge
		/// dispute. Will be null if the customer's bank or credit card company doesn't
		/// allow a response for this particular dispute.
		/// </summary>
		[JsonProperty("evidence_due_by")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? EvidenceDueBy { get; set; }

		/// <summary>
		/// Reason given by cardholder for dispute. Possible values are 'duplicate',
		/// 'fraudulent', 'subscription_canceled', 'product_unacceptable', 
		/// 'product_not_received', 'unrecognized', 'credit_not_processed', 'general'.
		/// Read more about dispute reasons at https://stripe.com/help/disputes#reasons.
		/// </summary>
		[JsonProperty("reason")]
		public string Reason { get; set; }

		/// <summary>
		/// Current status of the dispute. Possible value are 'won', 'lost', 
		/// 'needs_response', 'under_review'. 
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// Evidence that you have submitted to demonstrate the charge is legitimate
		/// (proof of delivery, IP addresses of logins, text of invoices, etc.). 1000
		/// characters maximum for most disputes, but 444 characters maximum for some
		/// kinds of American Express disputes.
		/// </summary>
		[JsonProperty("evidence")]
		public string Evidence { get; set; }
	}
}