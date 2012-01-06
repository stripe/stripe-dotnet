using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripePayment
	{
		[JsonProperty("card")]
		public StripeCardBase Card { get; set; }

		[JsonProperty("time")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? AttemptTime { get; set;}

		[JsonProperty("success")]
		public bool? Success { get; set; }

	}
}
