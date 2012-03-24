using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTokenCreateOptions : CreditCardOptions
	{
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }
	}
}