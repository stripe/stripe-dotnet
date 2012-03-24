using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeSubscription : StripeSubscriptionBase
	{
		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		[JsonProperty("current_period_start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? PeriodStart { get; set; }

		[JsonProperty("current_period_end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? PeriodEnd { get; set; }

		[JsonProperty("start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Start { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("canceled_at")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? CanceledAt { get; set; }

		[JsonProperty("ended_at")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? EndedAt { get; set; }
	}
}