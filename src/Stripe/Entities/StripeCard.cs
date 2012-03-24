using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCard : StripeCardBase
	{
		[JsonProperty("address_country")]
		public string AddressCountry { get; set; }

		[JsonProperty("address_state")]
		public string AddressState { get; set; }

		[JsonProperty("address_zip")]
		public string AddressZip { get; set; }

		[JsonProperty("address_zip_check")]
		public string AddressZipCheck { get; set; }

		[JsonProperty("address_line1")]
		public string AddressLine1 { get; set; }

		[JsonProperty("address_line1_check")]
		public string AddressLine1Check { get; set; }

		[JsonProperty("address_line2")]
		public string AddressLine2 { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("cvc_check")]
		public string CvcCheck { get; set; }

		[JsonProperty("exp_month")]
		public string ExpirationMonth { get; set; }

		[JsonProperty("exp_year")]
		public string ExpirationYear { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}