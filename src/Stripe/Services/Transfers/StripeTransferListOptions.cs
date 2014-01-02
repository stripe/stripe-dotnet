using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTransferListOptions : StripeListOptions
	{
		[JsonProperty("date")]
		public StripeDateFilter Date { get; set; }

		[JsonProperty("recipient")]
		public string Recipient { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
