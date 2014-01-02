using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeChargeListOptions : StripeListOptions
	{
		[JsonProperty("customer")]
		public string Customer { get; set; }

		[JsonProperty("created")]
		public StripeDateFilter Created { get; set; }
	}
}
