using Newtonsoft.Json;

namespace Stripe
{
	public class StripeEventData : StripeEntity
	{
		[JsonProperty("previous_attributes")]
		public dynamic PreviousAttributes { get; set; }

		[JsonProperty("object")]
		public dynamic Object { get; set; }
	}
}