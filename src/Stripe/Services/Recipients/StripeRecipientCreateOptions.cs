using Newtonsoft.Json;

namespace Stripe
{
	public class StripeRecipientCreateOptions : BankAccountOptions
	{
		public enum RecipientType
		{
			individual,
			corporation
		}

		/// <summary>
		/// The recipient's full, legal name. For type 'individual', should be in the
		/// format "First Last", "First Middle Last", or "First M Last" (no prefixes
		/// or suffixes). For 'corporation', the full incorporated name.
		/// </summary>
		/// <value>Required</value>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Type of the recipient: either 'individual' or 'corporation'.
		/// </summary>
		/// <value>Required</value>
		[JsonProperty("type")]
		public RecipientType Type { get; set; }

		/// <summary>
		/// The recipient's tax ID, as a string. For type 'individual', the full SSN;
		/// for type 'corporation', the full EIN.
		/// </summary>
		/// <value>Optional, default is null.</value>
		[JsonProperty("tax_id")]
		public string TaxId { get; set; }

		/// <summary>
		/// The recipient's email address. It is displayed alongside the recipient in
		/// the web interface and can be useful for searching and tracking.
		/// </summary>
		/// <value>Optional, default is null.</value>
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		/// An arbitrary string which you can attach to a recipient object. It is
		/// displayed alongside the recipient in the web interface.
		/// </summary>
		/// <value>Optional, default is null.</value>
		[JsonProperty("description")]
		public string Description { get; set; }
	}
}