using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeInvoiceItem
	{
	    public StripeInvoiceItem()
	    {
	        Metadata = new Dictionary<string, string>(10);
	    }

		[JsonProperty("id")]
		public string Id { get; set; }

        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }

		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Date { get; set; }

		[JsonProperty("proration")]
		public bool Proration{ get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("quantity")]
		public int? Quantity { get; set; }

		[JsonProperty("plan")]
		public StripePlan Plan { get; set; }

		[JsonProperty("period")]
		public StripePeriod Period { get; set; }

        /// <summary>
        /// Stripe only allows 10 kvps
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
	}
}
