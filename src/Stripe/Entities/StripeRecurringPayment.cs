using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeRecurringPayment
	{
		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		[JsonProperty("event")]
		public string Event { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		[JsonProperty("attempt")]
		public int? Attempt { get; set; }

		[JsonProperty("invoice")]
        public StripeInvoice StripeInvoice { get; set; }

		[JsonProperty("payment")]
        public StripePayment StripePayment { get; set; }
	}
}
