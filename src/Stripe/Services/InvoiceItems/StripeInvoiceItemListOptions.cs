using System;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeInvoiceItemListOptions : StripeListOptions
	{
		[JsonProperty("customer")]
		public string Customer { get; set; }

		[JsonProperty("date")]
		public StripeDateFilter Date { get; set; }
	}
}
