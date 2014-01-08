using System.CodeDom;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCustomerUpdateOptions : CreditCardOptions
	{
	    public StripeCustomerUpdateOptions()
	    {
            Metadata = new Dictionary<string, string>(10);
	    }

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

        /// <summary>
        /// Stripe only allows 10 kvps
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
	}
}
