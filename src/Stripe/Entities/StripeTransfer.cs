using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeTransfer
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Date { get; set; }

		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("other_transfers")]
		public List<string> OtherTransfers { get; set; }

		[JsonProperty("summary")]
		public StripeTransferSummary Summary { get; set; }
	}
}