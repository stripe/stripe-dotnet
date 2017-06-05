using Newtonsoft.Json;

namespace Stripe
{
	public class StripeEventRequest : StripeEntityWithId
	{
		[JsonProperty("idempotency_key")]
		public string IdempotencyKey { get; set; }
	}
}