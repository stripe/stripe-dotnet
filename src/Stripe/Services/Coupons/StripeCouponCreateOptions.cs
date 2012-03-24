using System;
using Newtonsoft.Json;

namespace Stripe
{
	public class StripeCouponCreateOptions
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("percent_off")]
		public int? PercentOff { get; set; }

		[JsonProperty("duration")]
		public string Duration { get; set; }

		[JsonProperty("duration_in_months")]
		public int? DurationInMonths { get; set; }

		[JsonProperty("max_redemptions")]
		public int? MaxRedemptions { get; set; }

		public DateTime? RedeemBy { get; set; }

		[JsonProperty("redeem_by")]
		internal int? RedeemByInternal
		{
			get
			{
				if (!RedeemBy.HasValue) return null;

				var diff = RedeemBy.Value - new DateTime(1970, 1, 1);

				return (int)Math.Floor(diff.TotalSeconds);
			}
		}
	}
}
