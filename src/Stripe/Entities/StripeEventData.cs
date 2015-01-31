using Newtonsoft.Json;

namespace Stripe
{
	public class StripeEventData
	{
#if NET40
		[JsonProperty("previous_attributes")]
		public dynamic PreviousAttributes { get; set; }

		[JsonProperty("object")]
		public dynamic Object { get; set; }
#else
		[JsonProperty("previous_attributes")]
		public object PreviousAttributes { get; set; }

		[JsonProperty("object")]
		public object Object { get; set; }
#endif
	}
}