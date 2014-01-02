using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeListOptions
	{
		[JsonProperty("count")]
		public int? Count { get; set; }

		[JsonProperty("offset")]
		public int? Offset { get; set; }
	}
}
