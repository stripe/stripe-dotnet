using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTransferCreateOptions
	{
		[JsonProperty("amount")]
		public int Amount { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("recipient")]
		public string Recipient { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("statement_description")]
		public string StatementDescription { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}
