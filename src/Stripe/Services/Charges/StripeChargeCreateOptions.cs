using Newtonsoft.Json;
namespace Stripe
{
	public class StripeChargeCreateOptions : CreditCardOptions
	{
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("customer")]
		public string CustomerId { get; set; }
	}
}