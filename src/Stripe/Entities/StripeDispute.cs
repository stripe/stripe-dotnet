using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeDispute
	{
		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("amount")]
		public int? Amount { get; set; }

		[JsonProperty("charge")]
		public string ChargeId { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("evidence_due_by")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? EvidenceDueBy { get; set; }

		[JsonProperty("reason")]
		public string Reason { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("evidence")]
		public string Evidence { get; set; }
	}
}