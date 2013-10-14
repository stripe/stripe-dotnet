using Newtonsoft.Json;

namespace Stripe
{
	public class StripePlanUpdateOptions
	{
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
