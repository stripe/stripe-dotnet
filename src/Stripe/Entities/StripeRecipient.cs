using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeRecipient
	{
		/// <summary>
		/// Type of the recipient, one of 'individual' or 'corporation'.
		/// </summary>
		public enum RecipientType
		{
			individual,
			corporation
		}

		[JsonProperty("id")]
		public string Id { get; set; }
		
		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }
		
		/// <summary>
		/// Timestamp
		/// </summary>
		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Created { get; set; }

		[JsonProperty("deleted")]
		public bool? Deleted { get; set; }

		/// <summary>
		/// Hash describing the current account on the recipient, if there is one.
		/// </summary>
		[JsonProperty("active_account")]
		public StripeActiveBankAccount ActiveAccount { get; set; }

		/// <summary>
		/// A bank account to attach to the recipient.
		/// </summary>
		[JsonProperty("bank_account")]
		public BankAccountOptions BankAccountOptions { get; set; }

		/// <summary>
		/// An arbitrary string which you can attach to a recipient object. It is displayed
		/// alongside the recipient in the web interface.
		/// </summary>
		/// <value>Default is null</value>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// The recipient's email address. It is displayed alongside the recipient in the 
		/// web interface and can be useful for searching and tracking.
		/// </summary>
		/// <value>Default is null</value>
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		/// The recipient's full, legal name.
		/// <example>For type 'individual', should be in the format "First Last", 
		/// "First Middle Last", or "First M Last" (no prefixes or suffixes).
		/// For type 'corporation', the full incorporated name.</example>
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Type of the recipient: either 'individual' or 'corporation'.
		/// </summary>
		[JsonProperty("type")]
		public RecipientType Type { get; set; }

		/// <summary>
		/// The recipient's tax ID, as a string. For type 'individual', the full SSN.
		/// For type 'corporation', the full EIN.
		/// </summary>
		[JsonProperty("tax_id")]
		public string TaxId { get; set; }
	}
}