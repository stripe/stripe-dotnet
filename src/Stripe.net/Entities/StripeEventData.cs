using Newtonsoft.Json;

namespace Stripe
{
	public class StripeEventData : StripeEntity
	{
        [JsonProperty("object")]
        public dynamic Object { get; set; }

		[JsonProperty("previous_attributes")]
		public dynamic PreviousAttributes { get; set; }

		public static explicit operator StripeCharge(StripeEventData evt) {
			return evt.Object.ToObject(typeof(StripeCharge));
		}
	}
}