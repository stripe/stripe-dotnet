using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeInvoiceLines
	{
		[JsonProperty("data")]
		public List<StripeInvoiceItem> StripeInvoiceItems { get; set; }
	}
}