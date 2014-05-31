using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;

namespace Stripe
{
	public class StripeCustomer : StripeObject
	{
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

		public string StripeDefaultCardId { get; set; }
		public StripeCard StripeDefaultCard { get; set; }
		[JsonProperty("default_card")]
		internal object InternalDefaultCard
		{
			set
			{
				if (value is JObject)
					StripeDefaultCard = Mapper<StripeCard>.MapFromJson(value.ToString());
				else
					StripeDefaultCardId = value == null ? null : value.ToString();
			}
		}

		[JsonProperty("cards")]
		public StripeCardList StripeCardList { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}