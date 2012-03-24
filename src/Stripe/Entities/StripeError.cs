using Newtonsoft.Json;

namespace Stripe
{
	public class StripeError
	{
		[JsonProperty("type")]
		public string ErrorType { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("param")]
		public string Parameter { get; set; }
	}
}