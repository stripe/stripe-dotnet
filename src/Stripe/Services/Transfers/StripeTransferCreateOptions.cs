using Newtonsoft.Json;

namespace Stripe
{
	public class StripeTransferCreateOptions
	{
		/// <summary>
		/// A positive integer in cents representing how much to transfer.
		/// </summary>
		[JsonProperty("amount")]
		public int AmountInCents { get; set; }

		/// <summary>
		/// Three-letter ISO code for currency.
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }

		/// <summary>
		/// The ID of an existing, verified recipient that the money will be transferred to in 
		/// this request. If 'self', the money will be transferred to the bank account associated
		/// with your account.
		/// </summary>
		[JsonProperty("recipient")]
		public string Recipient { get; set; }

		/// <summary>
		/// An arbitrary string which you can attach to a transfer object. It is displayed when
		/// in the web interface alongside the transfer.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// An arbitrary string which will be displayed on the recipient's bank statement. This
		/// should not include your company name, as that will already be part of the descriptor.
		/// The maximum length of this string is 15 characters; longer strings will be trucated.
		/// </summary>
		/// <remarks>
		/// For example, if your website is EXAMPLE.COM' and you pass in 'INVOICE 1234', the user
		/// will see 'EXAMPLE.COM INVOICE 1234'. Note: While most banks display this information
		/// consistently, some may display it incorrectly or not at all.
		/// </remarks>
		[JsonProperty("statement_descriptor")]
		public string StatementDescriptor { get; set; }
	}
}
