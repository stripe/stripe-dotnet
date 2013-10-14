using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeSubscription
	{
		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		/// <summary>
		/// Start of the current period that the subscription has been invoiced for.
		/// </summary>
		[JsonProperty("current_period_start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? PeriodStart { get; set; }

		/// <summary>
		/// End of the current period that the subscription has been invoiced for. At the end of this period,
		/// a new invoice will be created.
		/// </summary>
		[JsonProperty("current_period_end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? PeriodEnd { get; set; }

		/// <summary>
		/// Date the subscription started.
		/// </summary>
		[JsonProperty("start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Start { get; set; }

		/// <summary>
		/// Possible values are 'trialing', 'active', 'past_due', 'canceled', or 'unpaid'. A subscription
		/// still in its trial period is 'trialing' and moves to 'active' when the trial period is over.
		/// When payment to renew the subscription fails, the subscription becomes 'past_due'. After
		/// Stripe has exhausted all payment retry attempts, the subscription ends up with a status of either
		/// 'canceled' or 'unpaid' depending on your retry settings. Note that when a subscription has a status
		/// of 'unpaid', any future invoices will not be attempted until the customer's card details are updated.
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// A positive integer that represents the fee percentage of the subscription invoice amount that will
		/// be transferred to the application owner's Stripe account each billing period.
		/// </summary>
		[JsonProperty("canceled_at")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? CanceledAt { get; set; }

		/// <summary>
		/// If the subscription has ended (either because it was canceled or because the customer was switched
		/// from a subscription to a new plan), the date the subscription ended.
		/// </summary>
		[JsonProperty("ended_at")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? EndedAt { get; set; }

		/// <summary>
		/// If the subscription has a trial, the beginning of that trial.
		/// </summary>
		[JsonProperty("trial_start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? TrialStart { get; set; }

		/// <summary>
		/// If the subscription has a trial, the end of that trial.
		/// </summary>
		[JsonProperty("trial_end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? TrialEnd { get; set; }

		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		/// <summary>
		/// Hash describing the plan the customer is subscribed to.
		/// </summary>
		[JsonProperty("plan")]
		public StripePlan StripePlan { get; set; }

		/// <summary>
		/// If the subscription has been canceled with the <see cref="PeriodEnd"></see> flag set
		/// to true, <see cref="CancelAtPeriodEnd">CancelAtPeriodEnd</see> will be true. You can
		/// use this attribute to determine whether a subscription that has a status of active is
		/// scheduled to be canceled at the end of the current period.
		/// </summary>
		[JsonProperty("cancel_at_period_end")]
		public bool CancelAtPeriodEnd { get; set; }
	}
}