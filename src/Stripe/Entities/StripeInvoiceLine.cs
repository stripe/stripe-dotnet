using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeInvoiceLines
	{
		[JsonProperty("invoiceitems")]
		public List<StripeInvoiceItem> StripeInvoiceItems { get; set; }

		[JsonProperty("subscriptions")]
		public List<StripeInvoiceSubscription> StripeInvoiceSubscriptions { get; set; }
	}
}