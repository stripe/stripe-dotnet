using Newtonsoft.Json;

namespace Stripe
{
	public class StripeAccount
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("statement_descriptor")]
		public string StatementDescriptor { get; set; }

		[JsonProperty("details_submitted")]
		public bool DetailsSubmitted { get; set; }

		[JsonProperty("charge_enabled")]
		public bool ChargeEnabled { get; set; }

		[JsonProperty("currencies_supported")]
		public string[] CurrenciesSupported { get; set; }
	}
}
