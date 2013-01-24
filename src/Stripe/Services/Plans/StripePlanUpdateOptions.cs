using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripePlanUpdateOptions
	{
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
