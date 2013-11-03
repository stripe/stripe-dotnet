using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCard
	{
		/// <summary>
		/// ID of card (used in conjunction with a customer ID)
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Billing address country, if provided when creating card.
		/// </summary>
		[JsonProperty("address_country")]
		public string AddressCountry { get; set; }

		[JsonProperty("address_city")]
		public string AddressCity { get; set; }

		[JsonProperty("address_state")]
		public string AddressState { get; set; }

		[JsonProperty("address_zip")]
		public string AddressZip { get; set; }

		/// <summary>
		/// If <see cref="AddressZip">AddressZip</see> was provided, results
		/// of the check.
		/// </summary>
		/// <returns>'pass', 'fail' or 'unchecked'</returns>
		[JsonProperty("address_zip_check")]
		public string AddressZipCheck { get; set; }

		[JsonProperty("address_line1")]
		public string AddressLine1 { get; set; }

		[JsonProperty("address_line1_check")]
		public string AddressLine1Check { get; set; }

		[JsonProperty("address_line2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// Two-letter ISO code representing the country of the card. You could
		/// use this attribute to get a sense of the international breakdown 
		/// of cards you've collected.
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		/// <summary>
		/// If a CVC was provided, results of the check.
		/// </summary>
		/// <returns>String value: 'pass', 'fail' or 'unchecked'</returns>
		[JsonProperty("cvc_check")]
		public string CvcCheck { get; set; }

		[JsonProperty("exp_month")]
		public string ExpirationMonth { get; set; }

		[JsonProperty("exp_year")]
		public string ExpirationYear { get; set; }

		/// <summary>
		/// Cardholder name.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("last4")]
		public string Last4 { get; set; }

		/// <summary>
		/// Card brand. Can be 'Visa', 'American Express', 'MasterCard',
		/// 'Discover', 'JCB', 'Diners Club' or 'Unknown'.
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// Uniquely identifies this particular card number. You can use
		/// this attribute to check whether two customers who've signed
		/// up with you are using the same card number, for example.
		/// </summary>
		[JsonProperty("fingerprint")]
		public string Fingerprint { get; set; }
	}
}