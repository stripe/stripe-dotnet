using Newtonsoft.Json;

namespace Stripe
{
	public abstract class BankAccountOptions
	{
		[JsonProperty("bank_account[country]")]
		public string BankAccountCountry { get; set; }

		[JsonProperty("bank_account[routing_number]")]
		public string BankAccountRoutingNumber { get; set; }

		[JsonProperty("bank_account[account_number]")]
		public string BankAccountNumber { get; set; }
	}
}