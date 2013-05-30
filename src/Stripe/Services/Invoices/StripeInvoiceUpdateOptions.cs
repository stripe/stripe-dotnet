using Newtonsoft.Json;

namespace Stripe
{
	public class StripeInvoiceUpdateOptions
	{
		[JsonProperty("closed")]
		public bool Closed { get; set; }
	}
}
