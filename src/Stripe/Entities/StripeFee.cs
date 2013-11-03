using Newtonsoft.Json;

namespace Stripe
{
	public class StripeFee
	{
		[JsonProperty("amount")]
		public int AmountInCents { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("application")]
		public string Application { get; set; }

		[JsonProperty("type")]
		public string type { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}