using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeBalanceTransactionListOptions : StripeListOptions
	{
		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("source")]
		public string SourceId { get; set; }

		[JsonProperty("transfer")]
		public string TransferId { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}
}
