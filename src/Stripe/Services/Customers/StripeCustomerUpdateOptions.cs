using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCustomerUpdateOptions : CreditCardOptions
	{
		[JsonProperty("coupon")]
		public string Coupon { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("account_balance")]
		public int? AccountBalance { get; set; }

		[JsonProperty("default_card")]
		public string DefaultCard { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}
