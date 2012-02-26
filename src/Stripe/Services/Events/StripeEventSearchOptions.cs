using Newtonsoft.Json;
using System;

namespace Stripe
{
	public class StripeEventSearchOptions
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("created[gt]")]
		public DateTime? GreaterThan { get; set; }

		[JsonProperty("created[gte]")]
		public DateTime? GreaterThanOrEqualTo { get; set; }

		[JsonProperty("created[lt]")]
		public DateTime? LessThan { get; set; }

		[JsonProperty("created[lte]")]
		public DateTime? LessThanOrEqualTo { get; set; }

		public DateTime? Created { get; set; }

		[JsonProperty("created")]
		internal int? Createdinternal
		{
			get
			{
				if (!Created.HasValue) return null;

				var diff = Created.Value - new DateTime(1970, 1, 1);

				return (int)Math.Floor(diff.TotalSeconds);
			}
		}
	}
}