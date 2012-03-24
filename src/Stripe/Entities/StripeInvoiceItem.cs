using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeInvoiceItem
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Date { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}