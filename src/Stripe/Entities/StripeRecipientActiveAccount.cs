using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeRecipientActiveAccount : StripeObject
	{
		[JsonProperty("object")]
		public string Object { get; set; }

		[JsonProperty("bank_name")]
		public string BankName { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("last4")]
		public string Last4 { get; set; }

		[JsonProperty("disabled")]
		public bool? Disabled { get; set; }

		[JsonProperty("fingerprint")]
		public string Fingerprint { get; set; }

		[JsonProperty("validated")]
		public bool? Validated { get; set; }

		[JsonProperty("verified")]
		public bool? Verified { get; set; }
	}
}
