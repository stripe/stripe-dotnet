using Newtonsoft.Json;

namespace Stripe
{
	public abstract class BankAccountOptions
	{
		/// <summary>
		/// The country the bank account is in. Currently, only US is supported.
		/// </summary>
		[JsonProperty("bank_account[country]")]
		public string Country { get; set; }

		/// <summary>
		/// The routing number for the bank account in string form. This should be the 
		/// ACH routing number, not the wire routing number.
		/// </summary>
		[JsonProperty("bank_account[routing_number]")]
		public string RoutingNumber { get; set; }

		/// <summary>
		/// The account number for the bank account in string form. Must be a checking
		/// account.
		/// </summary>
		[JsonProperty("bank_account[account_number]")]
		public string AccountNumber { get; set; }
	}
}