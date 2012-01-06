using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeInvoiceLine
    {
        [JsonProperty("invoiceitems")]
        public List<StripeInvoiceItem> InvoiceItems { get; set; }

		[JsonProperty("subscriptions")]
		public List<StripeInvoiceSubscription> Subscriptions { get; set; }

    }
}