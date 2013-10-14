using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeInvoiceItem
	{
		/// <summary>
		/// The ID of the source of this line item, either an invoice item
		/// or a subscription.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// The amount, in cents.
		/// </summary>
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Date { get; set; }

		/// <summary>
		/// Three-letter ISO currency code.
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		/// <summary>
		/// A text description of the line item.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// The quantity of the subscription, if the line item is a 
		/// subscription.
		/// </summary>
		[JsonProperty("quantity")]
		public int? Quantity { get; set; }

		/// <summary>
		/// The plan of the subscription, if the line item is a 
		/// subscription.
		/// </summary>
		[JsonProperty("plan")]
		public StripePlan Plan { get; set; }

		/// <summary>
		/// The period this line item covers.
		/// </summary>
		[JsonProperty("period")]
		public StripePeriod Period { get; set; }
	}
}
