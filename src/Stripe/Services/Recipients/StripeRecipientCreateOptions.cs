using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeRecipientCreateOptions : BankAccountOptions
	{
	    public StripeRecipientCreateOptions()
	    {
            Metadata = new Dictionary<string, string>(10);
	    }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("tax_id")]
		public string TaxId { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}
