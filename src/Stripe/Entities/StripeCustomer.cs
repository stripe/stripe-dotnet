using System;
using System.Collections.Generic;
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

		[JsonProperty("delinquent")]
		public bool Delinquent { get; set; }

		[JsonProperty("discount")]
		public StripeDiscount StripeDiscount { get; set; }

		[JsonProperty("subscriptions")]
		public StripeSubscriptionList StripeSubscriptionList { get; set; }

		[JsonProperty("default_card")]
		public string StripeDefaultCardId { get; set; }

		[JsonProperty("cards")]
		public StripeCardList StripeCardList { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}