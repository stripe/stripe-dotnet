using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripePlanUpdateOptions
	{
	    public StripePlanUpdateOptions()
	    {
            Metadata = new Dictionary<string, string>(10);
	    }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}
