using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTokenCreateOptions : CreditCardOptions
	{
		[JsonProperty("customer")]
		public string CustomerId { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }
	}
}