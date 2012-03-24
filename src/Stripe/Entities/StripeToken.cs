using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeToken
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Created { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("used")]
		public bool? Used { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("card")]
		public StripeCard StripeCard { get; set; }
	}
}