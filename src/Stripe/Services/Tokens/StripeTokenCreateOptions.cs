using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTokenCreateOptions : CreditCardOptions
	{
		[JsonProperty("customer")]
		public string CustomerId { get; set; }
	}
}