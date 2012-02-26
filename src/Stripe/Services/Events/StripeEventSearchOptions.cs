using Newtonsoft.Json;
using System;

namespace Stripe
{
	public class StripeEventSearchOptions
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		public DateTime? Created { get; set; }
		public DateTime? LessThan { get; set; }
		public DateTime? LessThanOrEqualTo { get; set; }
		public DateTime? GreaterThan { get; set; }
		public DateTime? GreaterThanOrEqualTo { get; set; }

		[JsonProperty("created")]
		internal int? CreatedInternal { get { return ConvertToEpoch(Created); } }

		[JsonProperty("created[lt]")]
		internal int? LessThanInternal { get { return ConvertToEpoch(LessThan); } }

		[JsonProperty("created[lte]")]
		internal int? LessThanOrEqualToInternal { get { return ConvertToEpoch(LessThanOrEqualTo); } }

		[JsonProperty("created[gt]")]
		internal int? GreaterThanInternal { get { return ConvertToEpoch(GreaterThan); } }

		[JsonProperty("created[gte]")]
		internal int? GreaterThanOrEqualToInternal { get { return ConvertToEpoch(GreaterThanOrEqualTo); } }



		private int? ConvertToEpoch(DateTime? datetime)
		{
			if (!datetime.HasValue) return null;

			var diff = datetime.Value - new DateTime(1970, 1, 1);

			return (int)Math.Floor(diff.TotalSeconds);
		}
	}
}