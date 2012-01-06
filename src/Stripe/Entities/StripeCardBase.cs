using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCardBase
	{
		[JsonProperty("last4")]
		public string Last4 { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}
}
