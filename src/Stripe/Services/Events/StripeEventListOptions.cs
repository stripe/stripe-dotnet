using Newtonsoft.Json;
using System;

namespace Stripe
{
	public class StripeEventListOptions
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("created")]
		public StripeDateFilter Created { get; set; }
	}
}