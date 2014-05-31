using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Newtonsoft.Json.Linq;

namespace Stripe
{
	public class StripeInvoiceItem : StripeObject
	{
		[JsonProperty("amount")]
		public int? Amount { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Date { get; set; }

		[JsonProperty("proration")]
		public bool Proration { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		public string CustomerId { get; set; }
		public StripeCustomer Customer { get; set; }

		[JsonProperty("customer")]
		internal object InternalCustomer
		{
			set
			{
				if (value is JObject)
					Customer = Mapper<StripeCustomer>.MapFromJson(value.ToString());
				else
					CustomerId = value == null ? null : value.ToString();
			}
		}
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("quantity")]
		public int? Quantity { get; set; }

		[JsonProperty("plan")]
		public StripePlan Plan { get; set; }

		[JsonProperty("period")]
		public StripePeriod Period { get; set; }

		[JsonProperty("subscription")]
		public string SubscriptionId { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}
