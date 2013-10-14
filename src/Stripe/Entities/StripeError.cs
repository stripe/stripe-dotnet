using Newtonsoft.Json;

namespace Stripe
{
	public class StripeError
	{
		/// <summary>
		/// The type of error returned. Can be 'invalid_request_error', 
		/// 'api_error', or 'card_error'.
		/// </summary>
		[JsonProperty("type")]
		public string ErrorType { get; set; }

		/// <summary>
		/// A human-readable message giving more details about the error.
		/// For card errors, these messages can be shown to your users.
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; set; }

		/// <summary>
		/// For card errors, a short string from amongst those listed at
		/// https://stripe.com/docs/api/php#errors describing the kind of
		/// card error that occurred. 
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// The parameter the error relates to if the error is parameter-specific.
		/// You can use this to display a message near the correct form
		/// field, for example.
		/// </summary>
		[JsonProperty("param")]
		public string Parameter { get; set; }

		[JsonProperty("error")]
		public string Error { get; set; }

		[JsonProperty("error_description")]
		public string ErrorSubscription { get; set; }

		[JsonProperty("charge")]
		public string ChargeId { get; set; }
	}
}