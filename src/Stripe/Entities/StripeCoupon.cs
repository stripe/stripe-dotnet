using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeCoupon
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// One of 'forever', 'once', and 'repeating'. Describes how long a 
		/// customer who applies this coupon will get the discount.
		/// </summary>
		[JsonProperty("duration")]
		public string Duration { get; set; }

		/// <summary>
		/// If <see cref="Duration">Duration</see> is 'repeating', the number
		/// of months the coupon applies. Null if coupon 
		/// <see cref="Duration">Duration</see> is 'forever' or 'once'.
		/// </summary>
		[JsonProperty("duration_in_months")]
		public int? DurationInMonths { get; set; }

		[JsonProperty("livemode")]
		public bool? LiveMode { get; set; }

		/// <summary>
		/// Maximum number of times this coupon can be redeemed by a customer
		/// before it is no longer valid.
		/// </summary>
		[JsonProperty("max_redemptions")]
		public int? MaxRedemptions { get; set; }

		/// <summary>
		/// Amount (in the 'currency' specified) that will be taken off the
		/// subtotal of any invoices for this customer.
		/// </summary>
		[JsonProperty("amount_off")]
		public int? AmountOff { get; set; }

		/// <summary>
		/// Percent that will be taken off the subtotal of any invoices for 
		/// this customer for the duration of the coupon. For example, a 
		/// coupon with PercentOff of 50 will make a $100 invoice $50 instead.
		/// </summary>
		[JsonProperty("percent_off")]
		public int? PercentOff { get; set; }

		/// <summary>
		/// Date after which the coupon can no longe rbe redeemed.
		/// </summary>
		[JsonProperty("redeem_by")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? RedeemBy { get; set; }

		/// <summary>
		/// Number of times this coupon has been applied to a customer.
		/// </summary>
		[JsonProperty("times_redeemed")]
		public int TimesRedeemed { get; private set; }
	}
}
