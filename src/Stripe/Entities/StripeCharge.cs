using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using System.Collections.Generic;

namespace Stripe
{
	public class StripeCharge
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Amount charged in cents. Must be a positive
		/// integer or zero.
		/// </summary>
		[JsonProperty("amount")]
		public int? AmountInCents { get; set; }

		/// <summary>
		/// Amount in vents refunded (can be less than the amount attribute
		/// on the charge if a partial refund was issued).
		/// </summary>
		[JsonProperty("amount_refunded")]
		public int? AmountInCentsRefunded { get; set; }

		[JsonProperty("created")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime Created { get; set; }

		/// <summary>
		/// Three-letter ISO currency code.
		/// </summary>
		[JsonProperty("currency")]
		public string Currency { get; set; }

		/// <summary>
		/// ID of the customer this charge is for if one exists.
		/// </summary>
		[JsonProperty("customer")]
		public string CustomerId { get; set; }

		/// <summary>
		/// An arbitrary string which you can attach to a charge object.
		/// It is displayed within the web interface alongside the charge.
		/// It's often a good idea to use an email address as a description
		/// for tracking later. Note that if you use Stripe to send automatic
		/// email receipts to your customers, your receipt emails will include
		/// the description of the charge(s) that they are describing.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// A fee in cents that will be applied to the charge and 
		/// transferred to the application owner's Stripe account. The
		/// request must be made with an OAuth key in order to take an
		/// application fee.
		/// </summary>
		[JsonProperty("fee")]
		public int? FeeInCents { get; set; }

		[JsonProperty("fee_details")]
		public List<StripeFee> FeeDetails { get; set; }

		[JsonProperty("paid")]
		public bool? Paid { get; set; }

		/// <summary>
		/// Whether or not the charge has been fully refunded. If the 
		/// charge is only partially refunded, this attribute will
		/// still be false.
		/// </summary>
		[JsonProperty("refunded")]
		public bool? Refunded { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		/// <summary>
		/// A card to be charged. If you also pass a customer Id, the card 
		/// must be the ID of a card belonging to the customer. Otherwise, 
		/// if you do not pass a customer ID, the card you provide must either
		/// be a token, like the ones returned by Stripe.js, or an associative
		/// array containing a user's credit card details, with the options 
		/// described at https://stripe.com/docs/api/php#create_charge. 
		/// Although not all information is required, the extra info helps
		/// prevent fraud.
		/// </summary>
		[JsonProperty("card")]
		public StripeCard StripeCard { get; set; }

		/// <summary>
		/// ID of the invoice this charge is for if one exists.
		/// </summary>
		[JsonProperty("invoice")]
		public string InvoiceId { get; set; }

		/// <summary>
		/// Message to user further explaining reason for charge failure
		/// if available.
		/// </summary>
		[JsonProperty("failure_message")]
		public string FailureMessage { get; private set; }

		/// <summary>
		/// Error code explaining reason for charge failure if available
		/// (see https://stripe.com/docs/api#errors for a list of codes).
		/// </summary>
		[JsonProperty("failure_code")]
		public string FailureCode { get; private set; }

		/// <summary>
		/// If the charge was created without capturing, this boolean
		/// represents whether or not it is still uncaptured or has
		/// since been captured.
		/// </summary>
		[JsonProperty("captured")]
		public bool? Captured { get; set; }
	}
}