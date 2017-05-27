using Newtonsoft.Json;

namespace Stripe
{
	public class StripeEventRequest : StripeEntity
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("idempotency_key")]
		public string IdempotencyKey { get; set; }
	}
}