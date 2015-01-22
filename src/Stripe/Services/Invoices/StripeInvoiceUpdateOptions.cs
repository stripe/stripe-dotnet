using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeInvoiceUpdateOptions
	{
		[JsonProperty("closed")]
		public bool? Closed { get; set; }

		[JsonProperty("application_fee")]
		public int? ApplicationFee { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("forgiven")]
		public bool? Forgiven { get; set; }

		[JsonProperty("statement_descriptor")]
		public string StatementDescriptor { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}
