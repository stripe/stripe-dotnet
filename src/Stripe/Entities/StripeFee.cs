using Newtonsoft.Json;

namespace Stripe
{
	public class StripeFee
	{
		/// <summary>
		/// Amount in cents of the fee of at least 0 cents.
		/// </summary>
		[JsonProperty("amount")]
		public int AmountInCents { get; set; }

		/// <summary>
		/// Three-letter ISO currency code.
		/// </summary>
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