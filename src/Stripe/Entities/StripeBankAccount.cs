using Newtonsoft.Json;

namespace Stripe
{
	public class StripeBankAccount
	{
		[JsonProperty("bank_account[id]")]
		public string Id { get; set; }

		/// <summary>
		/// Name of the bank associated with the routing number, e.g. Wells Fargo.
		/// </summary>
		[JsonProperty("bacnk_account[bank_name]")]
		public string BankName { get; set; }

		/// <summary>
		/// Two-letter ISO code representing the country the bank account is located in.
		/// </summary>
		[JsonProperty("bank_account[country]")]
		public string Country { get; set; }

		/// <summary>
		/// Three-letter ISO currency code representing the currency paid out to the
		/// bank account.
		/// </summary>
		[JsonProperty("bank_account[currency]")]
		public string Currency { get; set; }

		[JsonProperty("bank_account[last4]")]
		public string LastFour { get; set; }

		/// <summary>
		/// Uniquely identifies this particular bank account. You can use this attribute
		/// to check whether two bank accounts are the same.
		/// </summary>
		[JsonProperty("bank_account[fingerprint]")]
		public string Fingerprint { get; set; }

		/// <summary>
		/// Whether or not the bank account exists. If false, there isn't enough information
		/// to know (e.g. for smaller credit unions), or the validation is not being run.
		/// </summary>
		[JsonProperty("bank_account[validated]")]
		public bool? Validated { get; set; }

		[JsonProperty("bank_account[verified]")]
		public bool? Verified { get; set; }
	}
}
