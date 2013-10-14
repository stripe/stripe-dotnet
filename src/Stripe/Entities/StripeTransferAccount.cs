using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTransferAccount
	{
		[JsonProperty("account[id]")]
		public string AccountId { get; set; }

		/// <summary>
		/// Name of the bank associated with the routing number, e.g. Wells Fargo.
		/// </summary>
		[JsonProperty("account[bank_name]")]
		public string BankName { get; set; }

		/// <summary>
		/// Two-letter ISO code representing the country the bank account is located in.
		/// </summary>
		[JsonProperty("account[country]")]
		public string Country { get; set; }

		/// <summary>
		/// Three-letter ISO currency code representing the currency paid out to the
		/// bank account.
		/// </summary>
		[JsonProperty("account[currency]")]
		public string AccountCurrency { get; set; }

		[JsonProperty("account[last4]")]
		public string LastFour { get; set; }

		/// <summary>
		/// Uniquely identifies this particular bank account. You can use this attribute
		/// to check whether two bank accounts are the same.
		/// </summary>
		[JsonProperty("account[fingerprint]")]
		public string Fingerprint { get; set; }

		/// <summary>
		/// Where or not the bank account exists. If false, there isn't enough information
		/// to know (e.g. for smaller credit unions), or the validation is not being run.
		/// </summary>
		[JsonProperty("account[validated]")]
		public bool? Validated { get; set; }

		[JsonProperty("account[verified]")]
		public bool? Verified { get; set; }
	}
}
