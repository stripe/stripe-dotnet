using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeCustomer
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("account_balance")]
		public int? AccountBalance { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		[JsonProperty("deleted")]
		public bool? Deleted { get; set; }

		/// <summary>
		/// Whether or not the latest charge for the customer's latest invoice has failed.
		/// </summary>
		[JsonProperty("delinquent")]
		public bool? Delinquent { get; set; }

		/// <summary>
		/// Describes the current discount active on the customer, if there is one.
		/// </summary>
		[JsonProperty("discount")]
		public StripeDiscount StripeDiscount { get; set; }

		/// <summary>
		/// Hash describing the current subscription on the customer, if there is one. If the
		/// customer has no current subscription, this will be null.
		/// </summary>
		[JsonProperty("subscription")]
		public StripeSubscription StripeSubscription { get; set; }

		/// <summary>
		/// ID of the default credit card attached to the customer.
		/// </summary>
		[JsonProperty("default_card")]
		public string StripeDefaultCardId { get; set; }

		[JsonProperty("cards")]
		public StripeCardList StripeCardList { get; set; }
	}
}