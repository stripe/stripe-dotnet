using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripeDiscount
	{
		[JsonProperty("id")]
		public string Id { get; set; }
		
		/// <summary>
		/// Date that the coupon was applied.
		/// </summary>
		[JsonProperty("start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Start { get; set; }

		/// <summary>
		/// If the coupon has a duration of 'once' or 'repeating', the date that
		/// this discount will end. If the coupon used has a 'forever' duration,
		/// this attribute will be null.
		/// </summary>
		[JsonProperty("end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? End { get; set; }

		/// <summary>
		/// Hash describing the coupon applied to create this discount.
		/// </summary>
		[JsonProperty("coupon")]
		public StripeCoupon StripeCoupon { get; set; }
	}
}
