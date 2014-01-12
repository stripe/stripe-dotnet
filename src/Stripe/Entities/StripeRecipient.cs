using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeRecipient
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("object")]
		public string Object { get; set; }

		[JsonProperty("livemode")]
		public bool LiveMode { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Created { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("active_account[id]")]
		public string ActiveAccountId { get; set; }

		[JsonProperty("active_account[object]")]
		public string ActiveAccountObject { get; set; }

		[JsonProperty("active_account[bank_name]")]
		public string ActiveAccountBankName { get; set; }

		[JsonProperty("active_account[country]")]
		public string ActiveAccountCountry { get; set; }

		[JsonProperty("active_account[currency]")]
		public string ActiveAccountCurrency { get; set; }

		[JsonProperty("active_account[last4]")]
		public string ActiveAccountLast4 { get; set; }

		[JsonProperty("active_account[fingerprint]")]
		public string ActiveAccountFingerprint { get; set; }

		[JsonProperty("active_account[validated]")]
		public bool? ActiveAccountValidated { get; set; }

		[JsonProperty("active_account[verified]")]
		public bool? ActiveAccountVerified { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("tax_id")]
		public string TaxId { get; set; }

		[JsonProperty("deleted")]
		public bool? Deleted { get; set; }

		[JsonProperty("verified")]
		public bool Verified { get; set; }

		[JsonProperty("metadata")]
		public Dictionary<string, string> Metadata { get; set; }
	}
}