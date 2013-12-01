using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeSubscription
	{
		[JsonProperty("id")]
		public string Id { get; set; }

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

		[JsonProperty("application_fee_percent")]
		public decimal? ApplicationFeePercent { get; set; }

		[JsonProperty("canceled_at")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? CanceledAt { get; set; }

		[JsonProperty("ended_at")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? EndedAt { get; set; }

		[JsonProperty("trial_start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? TrialStart { get; set; }

		[JsonProperty("trial_end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? TrialEnd { get; set; }

		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[JsonProperty("plan")]
		public StripePlan StripePlan { get; set; }

		[JsonProperty("cancel_at_period_end")]
		public bool CancelAtPeriodEnd { get; set; }
	}
}