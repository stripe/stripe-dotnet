﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	public class StripePeriod
	{
		[JsonProperty("start")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? Start { get; set; }

		[JsonProperty("end")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
		public DateTime? End { get; set; }
	}
}
