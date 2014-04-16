using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeApplicationFeeListOptions : StripeListOptions
	{
		[JsonProperty("charge")]
		public string Charge { get; set; }

		[JsonProperty("created")]
		public StripeDateFilter Created { get; set; }
	}
}
